using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dermalog.Afis.FingerCode3;
using Dermalog.AFIS.FourprintSegmentation;

namespace DermalogMultiScannerDemo
{
    public class LocalDB
    {

        public static String StoragePath1 = Environment.SpecialFolder.MyDocuments.ToString();
        public static String StoragePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DermalogMultiScannerDemo";
        private static String FILE_DEMOGRAPHIC = "user.txt";

        #region Folder-IO
        public static void makeDirectory()
        {
            if (!Directory.Exists(StoragePath))
                Directory.CreateDirectory(StoragePath);
        }

        public static void createUserFolder(LocalUser localUser)
        {
            String idString = localUser.ID.ToString("D6");
            String idPath = Path.Combine(StoragePath, idString);
            if (!Directory.Exists(idPath))
                Directory.CreateDirectory(idPath);

            String userPath = Path.Combine(idPath, FILE_DEMOGRAPHIC);
            StreamWriter sw = new StreamWriter(userPath);
            sw.Write(localUser.Name);
            sw.Flush();
            sw.Close();


            for (int i = 0; i < localUser.Fingerprints.Count; i++)
            {
                String templateString = String.Format("template{0}{1}.dat", i.ToString("D2"),
                        localUser.Fingerprints[i].Position.ToString("D2"));



                String templatePath = Path.Combine(idPath, templateString);
                FileStream fs = File.Create(templatePath);
                byte[] data = localUser.Fingerprints[i].Template.GetData();
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }
        }

        public static void createUserFolder_DBTable_old(LocalUser localUser, dynamic dd, Image pic_Webcam=null)
        {
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = Utils.getConnection();
                userTable_1 usr = new userTable_1();
                string idLength = string.Format("D{0}", Utils.get_ParamValue("IDLENGTH"));
                //string idLength = string.Format("D{0}", Utils.get_ParamValue(localUser.Name));
                String idString = localUser.ID.ToString(idLength);
                String idPath = Path.Combine(StoragePath, idString);
                if (!Directory.Exists(idPath))
                   Directory.CreateDirectory(idPath);

                String userPath = Path.Combine(idPath, FILE_DEMOGRAPHIC);
                StreamWriter sw = new StreamWriter(userPath);
                sw.Write(localUser.Name);
                sw.Flush();
                sw.Close();


                usr.id = localUser.ID;
                usr.idString = idString;
                usr.idPath = idPath;
                usr.userPath = FILE_DEMOGRAPHIC;
                usr.username = localUser.Name;
                usr.finger_remark = dd.remark;
                usr.createdby = dd.loggedin_staff;
                usr.LastActivityDate = DateTime.Now;
                usr.finger_Enrolled = "Y";

                if (pic_Webcam != null)
                {
                    //string strpath = idPath + @"\" + idString + ".jpg";
                    //pic_Webcam.Save(strpath);
                    //Task.Run(() =>
                    //{
                    //    MemoryStream ms = new MemoryStream();
                    //    pic_Webcam.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    //    byte[] bb = ms.ToArray();
                    //    //ms = null;
                    //    ms.Dispose();
                    //    ms.Close();
                    ////Image img = Image.FromFile(strpath);
                    ////byte[] bArr = imgToByteArray(img);

                    ////byte[] bb = Utils.convertImagetoBinary(pic_Webcam);
                    ////byte[] bb = Utils.convertImagetoBinary(pic_Webcam);
                    //usr.live_image = Utils.convert_byteArray2string(bb);
                    //}).Wait();
                    dynamic ue = new ExpandoObject();
                    ue.idstring = idString;
                    ue.Location = "Head Office";
                    ue.imageSTR= Utils.ImageToBase64(pic_Webcam);
                    ue.stage = "CAPTURE";
                    ue.capturedBy= dd.loggedin_staff;
                    ue.capturedDT= DateTime.Now;


                    object usertable_extension = ue;

                    string str = Newtonsoft.Json.JsonConvert.SerializeObject(usertable_extension);
                    //string APIHandle = @"infometriq-partner-api/capture/feedback";
                    string APIHandle = @"submit_usertable_extension";

                    string resp = "";
                    Task.Run(() =>
                    {
                        //resp = Utils.call_External_WEBAPI_Service(APIHandle, ss);
                        resp = Utils.call_WEBAPI_Service(APIHandle, str);

                    }).Wait();


                    usr.live_image = Utils.ImageToBase64(pic_Webcam); 

                }
                tx.userTable_1s.InsertOnSubmit(usr);
                

                for (int i = 0; i < localUser.Fingerprints.Count; i++)
                {
                    String templateString = String.Format("template{0}{1}.dat", i.ToString("D2"),
                            localUser.Fingerprints[i].Position.ToString("D2"));
                    
                    String fingerPos = String.Format("{0}{1}", i.ToString("D2"),
                                               localUser.Fingerprints[i].Position.ToString("D2"));

                    string Hand = String.Format("{0}", localUser.Fingerprints[i].Hand.ToString());
                    string HandPosition = String.Format("{0}", localUser.Fingerprints[i].Position.ToString("D2"));


                    String templatePath = Path.Combine(idPath, templateString);
                    FileStream fs = File.Create(templatePath);
                    byte[] data = localUser.Fingerprints[i].Template.GetData();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                    fs.Close();

                    fingerprint_Table fp = new fingerprint_Table();
                    fp.refNO = idString;
                    fp.position = fingerPos;
                    fp.hand_spec = Hand;
                    fp.hand_position = HandPosition;
                    fp.templatePath = idPath;
                    fp.templateString = templateString;
                    fp.finger_data = Utils.convert_byteArray2string( data);
                    tx.fingerprint_Tables.InsertOnSubmit(fp);

                }
                tx.SubmitChanges();
            }

        }

        public static string createUserFolder_DBTable(LocalUser localUser, dynamic dd, Image pic_Webcam = null)
        {
            String idString = "";
            //using (tranxDataContext tx = new tranxDataContext())
            {
               // tx.Connection.ConnectionString = Utils.getConnection();
                dynamic usr = new ExpandoObject();
                string idLength = string.Format("D{0}", Utils.get_ParamValue("IDLENGTH"));
                //string idLength = string.Format("D{0}", Utils.get_ParamValue(localUser.Name));
                //String idString = localUser.ID.ToString(idLength);
                //String idPath = Path.Combine(StoragePath, idString);
                String idPath = Path.Combine(StoragePath, "");
                //if (!Directory.Exists(idPath))
                //    Directory.CreateDirectory(idPath);

                //String userPath = Path.Combine(idPath, FILE_DEMOGRAPHIC);
                //StreamWriter sw = new StreamWriter(userPath);
                //sw.Write(localUser.Name);
                //sw.Flush();
                //sw.Close();
               

                //usr.id = localUser.ID;
                //usr.idString = idString;
                usr.idPath = idPath;
                usr.userPath = FILE_DEMOGRAPHIC;
                usr.username = localUser.Name;
                usr.finger_remark = dd.remark;
                usr.createdby = dd.loggedin_staff;
                //usr.LastActivityDate = DateTime.Now;
                usr.finger_Enrolled = "Y";

                if (pic_Webcam != null)
                {
                    dynamic ue = new ExpandoObject();
                    //ue.idstring = idString;
                    ue.Location = "Head Office";
                    ue.imageSTR = Utils.ImageToBase64(pic_Webcam);
                    ue.stage = "CAPTURE";
                    ue.capturedBy = dd.loggedin_staff;
                    ue.capturedDT = DateTime.Now;

                    usr.user_extension = ue;

                    //pic_Webcam.Save();

                    //object usertable_extension = ue;

                   // string str = Newtonsoft.Json.JsonConvert.SerializeObject(usertable_extension);
                    //string APIHandle = @"infometriq-partner-api/capture/feedback";
                    //string APIHandle = @"submit_usertable_extension";

                    ////string resp = "";
                    //Task.Run(() =>
                    //{
                    //    //resp = Utils.call_External_WEBAPI_Service(APIHandle, ss);
                    //    resp = Utils.call_WEBAPI_Service(APIHandle, str);

                    //}).Wait();


                   // usr.live_image = Utils.ImageToBase64(pic_Webcam);

                }
                //tx.userTable_1s.InsertOnSubmit(usr);

                List<object> fingerObject = new List<object>();
                for (int i = 0; i < localUser.Fingerprints.Count; i++)
                {
                    String templateString = String.Format("template{0}{1}.dat", i.ToString("D2"),
                            localUser.Fingerprints[i].Position.ToString("D2"));

                    String fingerPos = String.Format("{0}{1}", i.ToString("D2"),
                                               localUser.Fingerprints[i].Position.ToString("D2"));

                    string Hand = String.Format("{0}", localUser.Fingerprints[i].Hand.ToString());
                    string HandPosition = String.Format("{0}", localUser.Fingerprints[i].Position.ToString("D2"));


                    //String templatePath = Path.Combine(idPath, templateString);
                    //FileStream fs = File.Create(templatePath);
                    byte[] data = localUser.Fingerprints[i].Template.GetData();
                    //fs.Write(data, 0, data.Length);
                    //fs.Flush();
                    //fs.Close();

                    dynamic fp = new ExpandoObject();
                    //fp.refNO = idString;
                    fp.position = fingerPos;
                    fp.hand_spec = Hand;
                    fp.hand_position = HandPosition;
                    fp.templatePath = idPath;
                    fp.templateString = templateString;
                    fp.finger_data = Utils.convert_byteArray2string(data);
                    // tx.fingerprint_Tables.InsertOnSubmit(fp);
                    fingerObject.Add(fp);
                }

                usr.fingerprint = fingerObject;

                object usertable_extension = usr;

                string str = Newtonsoft.Json.JsonConvert.SerializeObject(usertable_extension);
                string resp = "";
                Task.Run(() =>
                {
                    string APIHandle = @"submit_usertable_extension";
                    //resp = Utils.call_External_WEBAPI_Service(APIHandle, ss);
                    resp = Utils.call_WEBAPI_Service(APIHandle, str);

                }).Wait();

                dynamic strResp = new ExpandoObject();
                strResp = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(resp);
                ;


                idString = strResp.idstring; ;
                //String idString = localUser.ID.ToString(idLength);
                idPath = Path.Combine(StoragePath, idString);
                if (!Directory.Exists(idPath))
                    Directory.CreateDirectory(idPath);

                String userPath = Path.Combine(idPath, FILE_DEMOGRAPHIC);
                StreamWriter sw = new StreamWriter(userPath);
                sw.Write(localUser.Name);
                sw.Flush();
                sw.Close();


                if (pic_Webcam != null)
                {
                    string storeImage = string.Format(@"{0}\{1}.jpg", idPath, idString);
                    pic_Webcam.Save(storeImage);
                }

                    for (int i = 0; i < localUser.Fingerprints.Count; i++)
                {
                    String templateString = String.Format("template{0}{1}.dat", i.ToString("D2"),
                            localUser.Fingerprints[i].Position.ToString("D2"));

                    String fingerPos = String.Format("{0}{1}", i.ToString("D2"),
                                               localUser.Fingerprints[i].Position.ToString("D2"));

                    string Hand = String.Format("{0}", localUser.Fingerprints[i].Hand.ToString());
                    string HandPosition = String.Format("{0}", localUser.Fingerprints[i].Position.ToString("D2"));


                    String templatePath = Path.Combine(idPath, templateString);
                    FileStream fs = File.Create(templatePath);
                    byte[] data = localUser.Fingerprints[i].Template.GetData();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                    fs.Close();

                   
                }


                //tx.SubmitChanges();
            }

            return idString;
        }

        public static Dictionary<long, LocalUser> convertFoldersToUserList()
        {
            LocalDB.makeDirectory();

            Dictionary<long, LocalUser> userList = new Dictionary<long, LocalUser>();

            string[] dirs = Directory.GetDirectories(StoragePath);

            if (dirs == null || dirs.Length == 0)
                return userList;

            foreach (string dir in dirs)
            {
                LocalUser localUser = new LocalUser();
                String dirId = Path.GetFileName(dir);
                localUser.ID = long.Parse(dirId);

                StreamReader sr = new StreamReader(Path.Combine(dir, FILE_DEMOGRAPHIC));
                localUser.Name = sr.ReadToEnd();
                sr.Close();
                try
                {
                    string[] templateFiles = Directory.GetFiles(dir, "template*");
                    foreach (string templateFile in templateFiles)
                    {
                        byte[] data = File.ReadAllBytes(templateFile);

                        String templateFileString = Path.GetFileNameWithoutExtension(templateFile);
                        String fingerPos = templateFileString.Substring(8, 2);

                        Fingerprint fingerprint = new Fingerprint();
                        fingerprint.Template = new Template();

                        //fingerprint.Template.Data = data;
                        string templateFormat = Properties.Settings.Default.TemplateFORMAT;
                        //fingerprint.Template.Format = Utils.Generate_Template_Encoder(templateFormat);

                        //fingerprint.Template.Format = data;

                        //fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                        fingerprint.Template.SetData(data, Utils.Generate_Template_Encoder(templateFormat));


                        //fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                        fingerprint.Position = UInt32.Parse(fingerPos);
                        localUser.Fingerprints.Add(fingerprint);
                    }

                    userList.Add(localUser.ID, localUser);
                }
                catch { }
            }

            return userList;
        }
        #endregion

        public static Dictionary<long, LocalUser> convertFoldersToUserList_New()
        {
            //LocalDB.makeDirectory();

            Dictionary<long, LocalUser> userList = new Dictionary<long, LocalUser>();

            using (tranxDataContext tx = new tranxDataContext())
            {

                // string[] dirs = Directory.GetDirectories(StoragePath);
                tx.Connection.ConnectionString = Utils.getConnection();
                var usr = tx.userTable_1s.Select(s => s).OrderBy(d => d.id);
                if(usr.Count()==0) return userList;

                //if (dirs == null || dirs.Length == 0)
                //    return userList;

                foreach (userTable_1 dir in usr)
                {
                    LocalUser localUser = new LocalUser();
                    //String dirId = Path.GetFileName(dir);
                    localUser.ID = long.Parse(dir.idString);

                    //StreamReader sr = new StreamReader(Path.Combine(dir, FILE_DEMOGRAPHIC));
                    localUser.Name = dir.username;
                    //sr.Close();
                    var fng = tx.fingerprint_Tables.Select(f => f).Where(w => w.refNO == dir.idString);
                    //string[] templateFiles = Directory.GetFiles(dir, "template*");

                    try
                    {
                        foreach (fingerprint_Table templateFile in fng)
                        {
                            byte[] data = Utils.convert_string2byteArray(templateFile.finger_data);

                            //String templateFileString = Path.GetFileNameWithoutExtension(templateFile);
                            String fingerPos = templateFile.position;

                            Fingerprint fingerprint = new Fingerprint();
                            fingerprint.Template = new Template();
                            fingerprint.Hand = (HandPositions)Enum.Parse(typeof(HandPositions), templateFile.hand_spec);
                            fingerprint.Position = (uint)  Convert.ToInt16( templateFile.hand_position);

                            //fingerprint.Template.Data = data;
                            string templateFormat = Properties.Settings.Default.TemplateFORMAT;
                            //fingerprint.Template.Format = Utils.Generate_Template_Encoder(templateFormat);

                            //fingerprint.Template.Format = data;

                            fingerprint.Template.SetData(data, Utils.Generate_Template_Encoder(templateFormat));

                            //fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                            //fingerprint.Position = UInt32.Parse(fingerPos);
                            localUser.Fingerprints.Add(fingerprint);
                        }

                        userList.Add(localUser.ID, localUser);
                    }
                    catch { }
                }
            }

            return userList;
        }

        public static Dictionary<long, LocalUser> convertFoldersTosingleUser(string username)
        {
            //LocalDB.makeDirectory();

            Dictionary<long, LocalUser> userList = new Dictionary<long, LocalUser>();

            using (tranxDataContext tx = new tranxDataContext())
            {

                // string[] dirs = Directory.GetDirectories(StoragePath);
                tx.Connection.ConnectionString = Utils.getConnection();
                var usr = tx.userTable_1s.FirstOrDefault(w=>w.idString==username);
                if (usr == null)
                {
                    return userList;
                }

                //if (dirs == null || dirs.Length == 0)
                //    return userList;
                else
                //foreach (userTable_1 dir in usr)
                {
                    LocalUser localUser = new LocalUser();
                    //String dirId = Path.GetFileName(dir);
                    localUser.ID = long.Parse(usr.idString);

                    //StreamReader sr = new StreamReader(Path.Combine(dir, FILE_DEMOGRAPHIC));
                    localUser.Name = usr.username;
                    //sr.Close();
                    var fng = tx.fingerprint_Tables.Select(f => f).Where(w => w.refNO == usr.idString);
                    //string[] templateFiles = Directory.GetFiles(dir, "template*");
                    foreach (fingerprint_Table templateFile in fng)
                    {
                        byte[] data = Utils.convert_string2byteArray(templateFile.finger_data);

                        //String templateFileString = Path.GetFileNameWithoutExtension(templateFile);
                        String fingerPos = templateFile.position;

                        Fingerprint fingerprint = new Fingerprint();
                        fingerprint.Template = new Template();

                        //fingerprint.Template.Data = data;
                        string templateFormat = Properties.Settings.Default.TemplateFORMAT;
                        //fingerprint.Template.Format = Utils.Generate_Template_Encoder(templateFormat);

                        //fingerprint.Template.Format = data;

                        fingerprint.Template.SetData(data, Utils.Generate_Template_Encoder(templateFormat));

                        //fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                        fingerprint.Position = UInt32.Parse(fingerPos);
                        localUser.Fingerprints.Add(fingerprint);
                    }

                    userList.Add(localUser.ID, localUser);
                }
            }

            return userList;
        }

    }
}
