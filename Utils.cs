using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Forms;
using Zen.Barcode;
using System.Configuration;
using System.Net;
using Dermalog.Afis.FingerCode3.Enums;
using System.Threading.Tasks;
using System.Dynamic;
using Dermalog.Afis.FingerCode3;
using Bunifu.UI.WinForms;
using Alertform;
using System.Text.RegularExpressions;

namespace DermalogMultiScannerDemo
{
    public static class Utils
    {
        public static readonly Brush COLOR_DERMALOG_GREEN = new SolidColorBrush(HexToMediaColor(0x11aa11));
        public static readonly Brush COLOR_DERMALOG_RED = new SolidColorBrush(HexToMediaColor(0xff0511));
        public static readonly Brush COLOR_DERMALOG_BLUE = new SolidColorBrush(HexToMediaColor(0x004289));



        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        public static BitmapSource BitmapToBitmapSource(System.Drawing.Bitmap bitmap)
        {
            IntPtr hBitmap = bitmap.GetHbitmap();
            BitmapSource img = null;
            try
            {
                img = Imaging.CreateBitmapSourceFromHBitmap(
                             hBitmap,
                             IntPtr.Zero,
                             System.Windows.Int32Rect.Empty,
                             BitmapSizeOptions.FromEmptyOptions());
                img.Freeze();
            }
            finally
            {
                DeleteObject(hBitmap);
            }
            return img;
        }
        public static System.Drawing.Image BitmapToBitmapSource2(System.Drawing.Bitmap bitmap)
        {
            //IntPtr hBitmap = bitmap.GetHbitmap();
            //BitmapSource img = null;
            //try
            //{
            //    img = Imaging.CreateBitmapSourceFromHBitmap(
            //                 hBitmap,
            //                 IntPtr.Zero,
            //                 System.Windows.Int32Rect.Empty,
            //                 BitmapSizeOptions.FromEmptyOptions());
            //    img.Freeze();
            //}
            //finally
            //{
            //    DeleteObject(hBitmap);
            //}
            //return img;
            return (System.Drawing.Image)bitmap;
        }


        public static void showAnimation(Control cs, BunifuAnimatorNS.BunifuTransition bunifuTransition1)
        {
            bunifuTransition1.HideSync(cs, true);
            //bunifuTransition1.HideSync(cs, false, BunifuAnimatorNS.Animation.HorizBlind);
            //Thread.Sleep(2000);
            bunifuTransition1.ShowSync(cs, true);

        }



        public static dynamic VERIFY_FingerPrints_METHOD(string refNO, Fingerprint fp, TemplateFormat template)
        {
            AFISVerificationResult result = new AFISVerificationResult();
            dynamic verify_Result = new ExpandoObject();
            //else
            {
                verify_Result.found = false;
                verify_Result.result = result;
                verify_Result.fingerPos = "not found";
            }

            int threshold = 30; // Properties.Settings.Default.VerificationThreshold;
            //List<Fingerprint> fg = new List<Fingerprint>();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();
                var fng = tx.fingerprint_Tables.Select(s => s).Where(w => w.refNO == refNO);
                //lst_feedback.Items.Clear();
                //foreach (fingerprint_Table_verify templateFile in fng)
                Parallel.ForEach(fng, (templateFile, loopState) =>
                {

                    //lst_feedback.Items.Insert(0, templateFile.refNO);

                    byte[] data = Utils.convert_string2byteArray(templateFile.finger_data);

                    //String templateFileString = Path.GetFileNameWithoutExtension(templateFile);
                    String fingerPos = templateFile.position;

                    Fingerprint fingerprint = new Fingerprint();
                    fingerprint.Template = new Template();


                    //fingerprint.Template.SetData(data, template);
                    fingerprint.Template.Data = data;
                    fingerprint.Template.Format = template;
                    //fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                    //fingerprint.Position = UInt32.Parse(fingerPos);
                    //fg.Add(fingerprint);

                    double dScore = new Matcher().Match(fingerprint.Template, fp.Template);
                    //double dScore = new Matcher().Match(userFingerprints[i].Template, fingerprints[j].Template);

                    if (dScore > threshold)
                    {
                        //dMaxScore = dScore;
                        result.Score = dScore; ;
                        result.Hit = true;
                        //return result;
                        verify_Result.found = true;
                        verify_Result.result = result;
                        verify_Result.fingerPos = fingerPos;
                        //verify_Result.ClientName = Utils.get_finger_username(templateFile.refNO);
                        //verify_Result.Name = templateFile.;
                        //tx.SubmitChanges();
                        //str.Append(user.Value.Name);
                        loopState.Stop();

                    }


                });
            }
            return verify_Result;
        }


        public static dynamic get_finger_Details(string refNO)
        {
            dynamic dd = new ExpandoObject();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();
                var ds = tx.userTable_1s
                    //.Where(w => w.idString == refNO)
                    //.Select(s => s.username)
                    .FirstOrDefault(w => w.idString == refNO);

                dd.username = ds.username;
                dd.Photo = ds.live_image;
                //dd.Photo = Utils.convert_string2byteArray(ds.live_image);
                return dd;

            }
            //return null
        }


        public static System.Drawing.Image Base64TOImage(string img)
        {

            //string path = @"D:\UBA\henry.jpg";
            //string path = @"D:\UBA\uba2.jpg";
            //using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            byte[] data = Utils.convert_string2byteArray(img);
            return convertBinarytoImage(data);


        }

        public static string ImageToBase64(PictureBox pi, bool test)
        {
            try
            {
                string base64String = null;
                //string path = @"D:\UBA\henry.jpg";
                //string path = @"C:\dermalog\fingerimage\myfinger.bmp";
                //string path = pi.ImageLocation;
                //using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
                using (System.Drawing.Image image = pi.Image.Clone() as System.Drawing.Image)
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        //pi.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imageBytes = m.ToArray();
                        base64String = Convert.ToBase64String(imageBytes);
                        return base64String;
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                return null;
            }
        }


        public static string ImageToBase64(PictureBox pi)
        {
            try
            {
                string base64String = null;
                //string path = @"D:\UBA\henry.jpg";
                //string path = @"C:\dermalog\fingerimage\myfinger.bmp";
                string path = pi.ImageLocation;
                //using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
                using (System.Drawing.Image image = pi.Image.Clone() as System.Drawing.Image)
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        //pi.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        image.Save(m, image.RawFormat);
                        //image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imageBytes = m.ToArray();
                        base64String = Convert.ToBase64String(imageBytes);
                        return base64String;
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                return null;
            }
        }

        public static string GetImageFromCamera(PictureBox pi)
        {
            string base64String = null;
            try
            {
                string DirPath = Properties.Settings.Default.ImageFolder; // @"C:\Users\user\Pictures\Camera Roll";
                DirectoryInfo df = new DirectoryInfo(DirPath);
                var dd = df.GetFiles("*.jpg").OrderByDescending(o => o.CreationTime).Select(s => s.FullName);
                //var dd = df.GetFiles("*.jpg")..AsEnumerable<FileInfo>().OrderByDescending(o => o.CreationTime).Select(s => s).FirstOrDefault();
                pi.Image = null;
                if (dd != null)
                {
                    pi.ImageLocation = dd.First();
                    pi.Refresh();
                    base64String = ImageToBase64(pi.Image);
                }



            }
            catch (Exception ex)
            {
                pi.Image = null;
                pi.Refresh();
                string str = ex.Message;
                return null;
            }

            return base64String;
        }

        public static string ImageToBase64(System.Drawing.Image pi)
        {
            try
            {
                string base64String = null;
                //string path = @"D:\UBA\henry.jpg";
                //string path = @"C:\dermalog\fingerimage\myfinger.bmp";
                //string path = pi.ImageLocation;
                //using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
                using (System.Drawing.Image image = pi.Clone() as System.Drawing.Image)
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        //pi.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        image.Save(m, image.RawFormat);
                        //image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imageBytes = m.ToArray();
                        base64String = Convert.ToBase64String(imageBytes);
                        return base64String;
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                return null;
            }
        }


        public static string getConnection()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.informetriQConnectionString))
            {

                return ConfigurationManager.ConnectionStrings["informetriQConnectionString"].ConnectionString;
            }
            else
            {
                return Properties.Settings.Default.informetriQConnectionString;
            }
        }

        public static string call_WEBAPI_Service(string API_Handle, string sample_request = "")
        {
            try
            {
                //var baseAddress = "http://www.bookersklub.com/ptmfb/testubasvccc/ubaverifysvc";
                //var baseAddress = "http://192.168.8.109/sam/ptmfb/testubasvccc/ubaverifysvc";
                string APIAddress = Properties.Settings.Default.webAPIAddress;
                //var baseAddress = "http://localhost/InfoMetriQ/VERIFY_templateSTR";
                // var baseAddress = string.Format(@"http://localhost/InfoMetriQ/{0}", API_Handle);
                //string APIAddress = @"http://10.50.58.138/WebApi_2020";
                var baseAddress = string.Format(@"{0}/{1}", APIAddress, API_Handle);
                //var baseAddress = Properties.Settings.Default.NIBSSAddress;
                //var cli = new WebClient();

                var cli = new WebClientEx();
                cli.Timeout = 900000; // Daft timeout period
                
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";

                string response = cli.UploadString(baseAddress, sample_request);

                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string call_External_WEBAPI_Service(string API_Handle, string sample_request = "")
        {
            try
            {
                //var baseAddress = "http://www.bookersklub.com/ptmfb/testubasvccc/ubaverifysvc";
                //var baseAddress = "http://192.168.8.109/sam/ptmfb/testubasvccc/ubaverifysvc";
                string APIAddress = Properties.Settings.Default.ExternalAPIAddress;
                //var baseAddress = "http://localhost/InfoMetriQ/VERIFY_templateSTR";
                // var baseAddress = string.Format(@"http://localhost/InfoMetriQ/{0}", API_Handle);
                var baseAddress = string.Format(@"{0}/{1}", APIAddress, API_Handle);
                //var baseAddress = Properties.Settings.Default.NIBSSAddress;
                var cli = new WebClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";

                string response = cli.UploadString(baseAddress, sample_request);

                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string call_WEBAPI_GETService(string API_Handle)
        {
            try
            {
                //var baseAddress = "http://www.bookersklub.com/ptmfb/testubasvccc/ubaverifysvc";
                //var baseAddress = "http://192.168.8.109/sam/ptmfb/testubasvccc/ubaverifysvc";
                string APIAddress = Properties.Settings.Default.webAPIAddress;
                //var baseAddress = "http://localhost/InfoMetriQ/VERIFY_templateSTR";
                // var baseAddress = string.Format(@"http://localhost/InfoMetriQ/{0}", API_Handle);
                var baseAddress = string.Format(@"{0}/{1}", APIAddress, API_Handle);
                //var baseAddress = Properties.Settings.Default.NIBSSAddress;
                var cli = new WebClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";

                string response = cli.DownloadString(baseAddress);

                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string call_External_WEBAPI_GETService(string API_Handle)
        {
            try
            {
                //var baseAddress = "http://www.bookersklub.com/ptmfb/testubasvccc/ubaverifysvc";
                //var baseAddress = "http://192.168.8.109/sam/ptmfb/testubasvccc/ubaverifysvc";
                string APIAddress = Properties.Settings.Default.ExternalAPIAddress;
                //string APIAddress = Properties.Settings.Default.webAPIAddress;

                //var baseAddress = "http://localhost/InfoMetriQ/VERIFY_templateSTR";
                // var baseAddress = string.Format(@"http://localhost/InfoMetriQ/{0}", API_Handle);
                var baseAddress = string.Format(@"{0}/{1}", APIAddress, API_Handle);
                //var baseAddress = Properties.Settings.Default.NIBSSAddress;
                var cli = new WebClient();
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";

                string response = cli.DownloadString(baseAddress);

                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static TemplateFormat Generate_Template_Encoder(string requestedTemplate)
        {
            Dermalog.Afis.FingerCode3.Encoder encoder = new Dermalog.Afis.FingerCode3.Encoder();
            //step_list.Items.Add("before generate 2");
            //encoder.Format = Dermalog.Afis.FingerCode3.Enums.TemplateFormat..ISO19794_2_2005_0001;
            //encoder.Format = Dermalog.Afis.FingerCode3.Enums.TemplateFormat.ISO19794_2_2005_0001;
            encoder.Format = (TemplateFormat)
                Enum.Parse(typeof(Dermalog.Afis.FingerCode3.Enums.TemplateFormat),
                requestedTemplate);

            return encoder.Format;
        }

        public static void bytetofile(string filename, byte[] fileBytes)
        {
            ////Read file to byte array

            //FileStream stream = File.OpenRead(@"c:\path\to\your\file\here.txt");
            //byte[] fileBytes = new byte[stream.Length];

            //stream.Read(fileBytes, 0, fileBytes.Length);
            //stream.Close();
            ////Begins the process of writing the byte array back to a file

            //using (Stream file = File.OpenWrite(@"c:\path\to\your\file\here.txt"))
            using (Stream file = File.OpenWrite(filename))
            {
                file.Write(fileBytes, 0, fileBytes.Length);
            }
        }

        public static byte[] filetobyte(string filename)
        {
            //Read file to byte array

            FileStream stream = File.OpenRead(filename);
            byte[] fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            stream.Close();

            return fileBytes;
            //Begins the process of writing the byte array back to a file

            ////using (Stream file = File.OpenWrite(@"c:\path\to\your\file\here.txt"))
            //using (Stream file = File.OpenWrite(filename))
            //{
            //    file.Write(fileBytes, 0, fileBytes.Length);
            //}
        }

        public static List<string> get_usernames(string contains)
        {
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();
                if (!string.IsNullOrEmpty(contains))
                {
                    var ds = tx.userTable_1s.Where(w => w.username.StartsWith(contains))
                        .Select(s => s.username).ToList();


                    return ds;
                }
                else
                {
                    var ds = tx.userTable_1s
                       .Select(s => s.username).ToList();


                    return ds;
                }

            }
        }

        public static bool check_usernames_exist(string contains)
        {
            bool found = false;
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();
                if (!string.IsNullOrEmpty(contains))
                {
                    var ds = tx.userTable_1s.FirstOrDefault(w => w.username == contains);


                    if (ds != null) found = true;
                }

            }
            return found;
        }

        public static dynamic check_InternetID_exist(string contains)
        {
            dynamic found = new ExpandoObject();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();

                found.status = false;
                found.idstring = "";
                found.username = contains;
                found.remark = "Username must not be empty.";



                if (!string.IsNullOrEmpty(contains))
                {
                    var ds = tx.individual_datas.FirstOrDefault(w => w.username == contains);
                    found.status = false;
                    found.idstring = "";
                    found.username = contains;
                    found.remark = "Client Data Not Downloaded yet";

                    if (ds != null)
                    {

                        found.status = true;
                        found.idstring = "";
                        found.username = ds.username;
                        found.remark = "Client Data Downloaded, but yet to Enroll";
                        found.enrolled = false;

                        var ds2 = tx.userTable_1s
                            .FirstOrDefault(w => (w.username == contains) || (w.idString == contains));
                        if (ds2 != null)
                        {
                            found.status = true;
                            found.idstring = ds2.idString;
                            found.username = ds2.username;
                            found.remark = "Client already Enrolled......";
                            found.enrolled = true;
                            //found.Add(ds2.idString, ds2.username);
                        }
                    }
                    else
                    {
                        var ds2 = tx.userTable_1s.FirstOrDefault(w => (w.username == contains) || (w.idString == contains));
                        if (ds2 != null)
                        {
                            found.status = true;
                            found.idstring = ds2.idString;
                            found.username = ds2.username;
                            found.remark = "Client Data not Downloaded, but " + Environment.NewLine + "Client already Enrolled......";
                            found.enrolled = false;
                            //found.Add(ds2.idString, ds2.username);
                        }
                    }
                }

            }
            return found;
        }

        public static void show_ClientExist(String enteredUsername)
        {
            //pix_login.Visible = true;
            //String enteredUsername = xamlTextBoxUsername.Text.Trim();
            //individual_data strResponse = null;
            dynamic strResponse = new ExpandoObject();
            //Task.Run(() =>
            {

                {
                   
                    using (tranxDataContext tx = new tranxDataContext())
                    {
                        tx.Connection.ConnectionString = Utils.getConnection();
                        var ds = tx.individual_datas
                            .FirstOrDefault(s => s.username == enteredUsername);

                        if (ds != null)
                        {


                            strResponse = ds;
                            winforms.Form_data fm = new winforms.Form_data(strResponse, true);
                            fm.ShowDialog();

                        }
                        else
                        {
                            AlertForm1 al = new AlertForm1("Individual Data noavailable Locally", 
                                AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                            al.ShowDialog();
                        }
                        //strResponse = Newtonsoft.Json.JsonConvert.SerializeObject(ds);
                    }
                    //strResponse = Utils.call_WEBAPI_GETService("infometriq-partner-api/individuals");
                }
            }
            //).Wait();


            //AlertForm1 fmm = new AlertForm1("Client Data Received Successfully.....");
            //fmm.ShowDialog();

            //pix_login.Visible = false;


            
        }

        public static string TrimNonAscii(string value)
        {
            string pattern = "[^ -~]+";
            Regex reg_exp = new Regex(pattern);
            return reg_exp.Replace(value, "");
        }


        public static void show_ClientExist_Online(String enteredUsername)
        {
            //pix_login.Visible = true;
            string strResponse = "";
            Task.Run(() =>
            {

                {
                    // displayMessage("Verifying Template File.....", Utils.COLOR_DERMALOG_RED);
                    //string externalAPI = Properties.Settings.Default.ExternalAPIAddress;
                    string servNAME = string.Format("customer/{0}", enteredUsername);
                    // string servNAME = string.Format("infometriq-partner-api/individuals/{0}/username", enteredUsername);
                    strResponse = call_External_WEBAPI_GETService(servNAME);
                    //strResponse = Utils.call_WEBAPI_GETService("infometriq-partner-api/individuals");
                }
            }
           ).Wait();

            // pix_login.Visible = false;

            winforms.Form_data fm = new winforms.Form_data(strResponse);
            fm.ShowDialog();
        }



        public static Dictionary<string, string> check_InternetID_exist_old(string contains)
        {
            Dictionary<string, string> found = new Dictionary<string, string>();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();
                if (!string.IsNullOrEmpty(contains))
                {
                    var ds = tx.individual_datas.FirstOrDefault(w => w.username == contains);


                    if (ds != null)
                    {
                        var ds2 = tx.userTable_1s.FirstOrDefault(w => w.username == contains);
                        if (ds2 != null)
                        {
                            found.Add(ds2.idString, ds2.username);
                        }
                    }
                }

            }
            return found;
        }

        public static Dictionary<string, string> get_RefCode(string contains)
        {
            Dictionary<string, string> found = new Dictionary<string, string>();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();
                if (!string.IsNullOrEmpty(contains))
                {

                    var ds2 = tx.userTable_1s.FirstOrDefault(w => w.username == contains);
                    if (ds2 != null)
                    {
                        string newID = "NGN-IID-" + ds2.idString;
                        found.Add(newID, ds2.username);
                    }

                }

            }
            return found;
        }
        public static string get_ParamValue(string key)
        {
            string retval = "";
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = getConnection();
                if (!string.IsNullOrEmpty(key))
                {

                    var ds2 = tx.appControlTable_1s.FirstOrDefault(w => w.paramName == key);
                    if (ds2 != null)
                    {
                        retval = ds2.paramValue;
                    }

                }

            }
            return retval;
        }

        public async static void get_templateFORMAT(ComboBox cb_templateFormat)
        {
            string str = await Task.Run(() => Utils.call_WEBAPI_GETService("Get_SupportedTemplateList"));

            List<string> dd = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(str);

            cb_templateFormat.DataSource = dd;

            cb_templateFormat.Refresh();
        }
        public static void gen_barcode(PictureBox pixBarcode, string str)
        {
            try
            {
                Code128BarcodeDraw _barcode = BarcodeDrawFactory.Code128WithChecksum;
                pixBarcode.Image = _barcode.Draw(str, 50);
            }
            catch { }
        }


        public static List<Fingerprint> combine_fingers(
            List<Fingerprint> fingerprints_left, List<Fingerprint> fingerprints_right,
            List<Fingerprint> fingerprints_mid)
        {

            List<Fingerprint> fingerprints_all = new List<Fingerprint>();
            if (fingerprints_left.Count() > 0) fingerprints_all.AddRange(fingerprints_left);
            if (fingerprints_right.Count() > 0) fingerprints_all.AddRange(fingerprints_right);
            if (fingerprints_mid.Count() > 0) fingerprints_all.AddRange(fingerprints_mid);

            return fingerprints_all;
        }

        public static string convert_byteArray2string(byte[] bytes)
        {

            //byte[] bytes = Convert.FromBase64String("QUJDMTIz");
            //Console.WriteLine("Byte Array is: " + String.Join(" ", bytes));

            string str = "";
            if (bytes != null)
            {
                str = Convert.ToBase64String(bytes) ?? "";
                // Console.WriteLine("The String is: " + str);
            }
            return str;
        }

        public static byte[] convert_string2byteArray(string str)
        {

            byte[] bytes = null;

            if (!string.IsNullOrEmpty(str))
            {
                bytes = Convert.FromBase64String(str);
                // Console.WriteLine("Byte Array is: " + String.Join(" ", bytes));

                //string str = Convert.ToBase64String(bytes);
                //Console.WriteLine("The String is: " + str);
            }
            return bytes;
        }
        public static byte[] convertImagetoBinary(System.Drawing.Image img)
        {
            if (img != null)
            {

                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();

                //using (MemoryStream mStream = new MemoryStream())
                //{
                //    img.Save(mStream, img.RawFormat);
                //    return mStream.ToArray();
                //}


                //using (MemoryStream ms = new MemoryStream())
                //{
                //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //    return ms.ToArray();
                //}
            }
            else
            {
                return null;
            }
        }
        //retrieve the image from database
        public static System.Drawing.Image convertBinarytoImage(byte[] data)
        {
            //System.Drawing.Image mm = null;
            if (data != null)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {

                    return System.Drawing.Image.FromStream(ms);
                }
            }
            else
            {
                return null;
            }
        }

        public static void truncate_tables()
        {
            //using(tranxDataContext tx = new tranxDataContext())
            //{
            //    tx.Connection.ConnectionString = getConnection();
            //    int i2 = tx.ExecuteCommand("truncate table usertable_1");
            //     i2 = tx.ExecuteCommand("truncate table fingerprint_Table");
            //    i2 = tx.ExecuteCommand("truncate table userTable_Extension");

            //}

            string strResponse = "";
            Task.Run(() =>
            {

                {
                    // displayMessage("Verifying Template File.....", Utils.COLOR_DERMALOG_RED);
                    //string externalAPI = Properties.Settings.Default.ExternalAPIAddress;
                    string APIName = "ZAP_BiometricData";
                    // string servNAME = string.Format("infometriq-partner-api/individuals/{0}/username", enteredUsername);
                    strResponse = call_WEBAPI_GETService(APIName);
                    //strResponse = Utils.call_WEBAPI_GETService("infometriq-partner-api/individuals");
                }
            }
           ).Wait();


        }
        public static System.Drawing.Bitmap BitmapFromSource(BitmapSource bitmapsource)
        {
            System.Drawing.Bitmap bitmap;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapsource));
                enc.Save(outStream);
                bitmap = new System.Drawing.Bitmap(outStream);
            }
            return bitmap;
        }

        public static Brush GetBrushFromNFIQ(int nfiq)
        {
            Brush fontColor = Brushes.Black;
            switch (nfiq)
            {
                case 1:
                    fontColor = COLOR_DERMALOG_GREEN;
                    break;
                case 2:
                    fontColor = Brushes.DarkOrange;
                    break;
                case 3:
                    fontColor = Brushes.DarkOrange;
                    break;
                case 4:
                    fontColor = Brushes.DarkOrange;
                    break;
                case 5:
                    fontColor = COLOR_DERMALOG_RED;
                    break;
            }
            return fontColor;
        }

        public static Color ToMediaColor(System.Drawing.Color color)
        {
            return Color.FromArgb(0xFF, color.R, color.G, color.B);
        }

        public static System.Drawing.Color HexToColor(int rgb)
        {
            return System.Drawing.Color.FromArgb(rgb);
        }

        public static Color HexToMediaColor(int rgb)
        {
            return ToMediaColor(HexToColor(rgb));
        }
    }

    public class WindowWrapper : System.Windows.Forms.IWin32Window
    {
        public WindowWrapper(IntPtr handle)
        {
            _hwnd = handle;
        }

        public WindowWrapper(Window window)
        {
            _hwnd = new WindowInteropHelper(window).Handle;
        }

        public IntPtr Handle
        {
            get { return _hwnd; }
        }

        private IntPtr _hwnd;
    }

    public class WebClientEx : WebClient
    {
        public int Timeout { get; set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            request.Timeout = Timeout;
            return request;
        }
    }
}