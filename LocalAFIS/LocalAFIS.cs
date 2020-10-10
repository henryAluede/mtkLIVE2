using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dermalog.Afis.FingerCode3;

namespace DermalogMultiScannerDemo
{
    public class LocalAFIS
    {
        private Dictionary<long, LocalUser> _userList;
        private Dictionary<long, LocalUser> _userList_new;
        private Dictionary<long, LocalUser> _singleuser_new;
        private long _nextId = 0;

        public string StoragePath
        {
            get
            {
                return LocalDB.StoragePath;
            }
        }

        public LocalAFIS()
        {
            _userList = LocalDB.convertFoldersToUserList();
            _userList_new = LocalDB.convertFoldersToUserList_New();
           

            _nextId = getMaxId();
        }

        
        public bool IsEmpty()
        {
            return _userList.Count == 0;
        }

        #region ID Logic
        private long getMaxId()
        {
            if (_userList.Keys.Count == 0)
                return 0;
            return _userList.Keys.Max();
        }

        private long getNextId()
        {
            return ++_nextId;
        }
        #endregion

        #region User Database Logic
        public Dictionary<long, LocalUser> GetUserList()
        {
            return _userList;

        }
        public Dictionary<long, LocalUser> GetUserList_New()
        {
           
            return _userList_new;

        }

        public Dictionary<long, LocalUser> GetSingleUser_New(string username)
        {
            _singleuser_new = LocalDB.convertFoldersTosingleUser(username);
            return _singleuser_new;

        }

        public LocalUser RegisterUser(String name, List<Fingerprint> fingerprints, dynamic dd,Image pic_Webcam=null)
        {
            LocalUser localUser = new LocalUser();
           
            localUser.Name = name;
            //localUser.FingerSETName= 
            localUser.Fingerprints = fingerprints;


            String idString = "";

            try
            {
                Task.Run(() =>
                {
                    //LocalDB.createUserFolder(localUser);
                    //Newly created to handle the database side
                    idString = LocalDB.createUserFolder_DBTable(localUser, dd, pic_Webcam);
                }).Wait();
            }
            catch(Exception ex)
            {
                string str = ex.Message;
            }

            localUser.ID = long.Parse(idString);
            //localUser.ID = getNextId();
            _userList.Add(localUser.ID, localUser);
            _userList_new.Add(localUser.ID, localUser);



            return localUser;
        }

        

        public AFISVerificationResult VerifyUser(long userId, List<Fingerprint> fingerprints, int threshold)
        {
            AFISVerificationResult result = new AFISVerificationResult();

            if (!_userList.ContainsKey(userId))
            {
                throw new Exception("USER NOT REGISTERED");
            }

            LocalUser user = _userList[userId];
            List<Fingerprint> userFingerprints = user.Fingerprints;

            double dMaxScore = 0.0;

            for (int i = 0; i < userFingerprints.Count; i++)
            {
                for (int j = 0; j < fingerprints.Count; j++)
                {
                    double dScore = new Matcher().Match(userFingerprints[i].Template, fingerprints[j].Template);

                    if (dScore > threshold && dScore > dMaxScore)
                    {
                        dMaxScore = dScore;
                        result.Score = dMaxScore;
                        result.Hit = true;
                        return result;
                    }
                }
            }

            return result;
        }

        public AFISVerificationResult VerifyUser_New(long userId, List<Fingerprint> fingerprints, int threshold)
        {
            AFISVerificationResult result = new AFISVerificationResult();

            if (!_userList_new.ContainsKey(userId))
            {
                throw new Exception("USER NOT REGISTERED");
            }

            LocalUser user = _userList_new[userId];
            List<Fingerprint> userFingerprints = user.Fingerprints;

            double dMaxScore = 0.0;

            //for (int i = 0; i < userFingerprints.Count; i++)
            Parallel.ForEach(userFingerprints, (fgn, loopout) =>
             {
                 for (int j = 0; j < fingerprints.Count; j++)
                 {
                     double dScore = new Matcher().Match(fgn.Template, fingerprints[j].Template);
                     //double dScore = new Matcher().Match(userFingerprints[i].Template, fingerprints[j].Template);

                     if (dScore > threshold && dScore > dMaxScore)
                     {
                         dMaxScore = dScore;
                         result.Score = dMaxScore;
                         result.Hit = true;
                         //return result;
                         loopout.Stop();
                     }
                 }
             });

            return result;
        }

        public AFISVerificationResult IdentifyUser(long userId, List<Fingerprint> fingerprints, int threshold)
        {
            AFISVerificationResult result = new AFISVerificationResult();

            //if (!_userList.ContainsKey(userId))
            //{
            //    throw new Exception("USER NOT REGISTERED");
            //}

            LocalUser user = _userList[userId];
            List<Fingerprint> userFingerprints = user.Fingerprints;

            double dMaxScore = 0.0;

            for (int i = 0; i < userFingerprints.Count; i++)
            {
                for (int j = 0; j < fingerprints.Count; j++)
                {
                    double dScore = new Matcher().Match(userFingerprints[i].Template, fingerprints[j].Template);

                    if (dScore > threshold && dScore > dMaxScore)
                    {
                        dMaxScore = dScore;
                        result.Score = dMaxScore;
                        result.Hit = true;
                        return result;
                    }
                }
            }

            return result;
        }

        public AFISVerificationResult IdentifyUser_New(long userId, List<Fingerprint> fingerprints, int threshold)
        {
            AFISVerificationResult result = new AFISVerificationResult();

            //if (!_userList.ContainsKey(userId))
            //{
            //    throw new Exception("USER NOT REGISTERED");
            //}

            LocalUser user = _userList_new[userId];
            List<Fingerprint> userFingerprints = user.Fingerprints;

            double dMaxScore = 0.0;

            //for (int i = 0; i < userFingerprints.Count; i++)
            Parallel.ForEach (userFingerprints, (usertemplate, loopState) =>
            {
                for (int j = 0; j < fingerprints.Count; j++)
                {
                    double dScore = new Matcher().Match(usertemplate.Template, fingerprints[j].Template);
                   //double dScore = new Matcher().Match(userFingerprints[i].Template, fingerprints[j].Template);

                    if (dScore > threshold && dScore > dMaxScore)
                    {
                        dMaxScore = dScore;
                        result.Score = dMaxScore;
                        result.Hit = true;
                        result.Hand = usertemplate.Hand.ToString();
                        result.HandPosition = Convert.ToInt32( usertemplate.Position).ToString();
                        loopState.Stop();
                        //return result;
                    }
                }
            });

            return result;
        }




        #endregion
    }

    public class AFISVerificationResult
    {
        private double _score;
        public double Score
        {
            get { return _score; }
            set { _score = value; }
        }

        private bool _hit = false;
        public bool Hit
        {
            get { return _hit; }
            set { _hit = value; }
        }

        private string _hand ;
        public string Hand
        {
            get { return _hand; }
            set { _hand = value; }
        }

        private string _handPosition;
        public string HandPosition
        {
            get { return _handPosition; }
            set { _handPosition = value; }
        }
    }
}
