using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace SampleDB
{
    public class UserGroupPageViewModel :INotifyPropertyChanged
    {

        public class JSSEInfo
        {
            public int jsseId { get; set; }
            public string jsseStatus { get; set; }
            public string jsseDate { get; set; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Group> GroupItems { get; set; }



        public int SelectedGroupId;


        public ObservableCollection<JSSEInfo> finalListObj = new ObservableCollection<JSSEInfo>();

       

        private ObservableCollection<JSSEInfo> _listeviewItemSource = new ObservableCollection<JSSEInfo>();

        public ObservableCollection<JSSEInfo> ListeviewItemSource
        {   
            set
            {
                _listeviewItemSource = value;
                OnPropertyChanged("ListeviewItemSource");
            }
            get { return _listeviewItemSource; }
        }


        public UserGroupPageViewModel()
        {

            var assembly = typeof(DynamicScreen).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("SampleDB.UserGroup.json");
            using (var reader = new System.IO.StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                UserGroupModel userGroupModel = JsonConvert.DeserializeObject<UserGroupModel>(json);

                List<Group> sortingGroup = new List<Group>();
                for (int i = 0; i < userGroupModel.Groups.Count; i++)
                {
                    if (userGroupModel.Groups[i].GroupType.Level_Id == 2)
                    {
                        sortingGroup.Add(userGroupModel.Groups[i]);
                    }
                }

                //pickerRef.ItemsSource = sortingGroup;
                GroupItems = sortingGroup;
            }


            JSSEInfo obj = new JSSEInfo();
            obj.jsseId = 500;
            obj.jsseStatus = "Draft";
            obj.jsseDate = "09/20/2017";


            JSSEInfo obj1 = new JSSEInfo();
            obj1.jsseId = 501;
            obj1.jsseStatus = "Submit";
            obj1.jsseDate = "09/20/2017";


            JSSEInfo obj2 = new JSSEInfo();
            obj2.jsseId = 502;
            obj2.jsseStatus = "Submit";
            obj2.jsseDate = "09/20/2017";


            JSSEInfo obj3 = new JSSEInfo();
            obj3.jsseId = 503;
            obj3.jsseStatus = "Draft";
            obj3.jsseDate = "09/20/2017";


            JSSEInfo obj4 = new JSSEInfo();
            obj4.jsseId = 504;
            obj4.jsseStatus = "Submit";
            obj4.jsseDate = "09/20/2017";


            JSSEInfo obj5 = new JSSEInfo();
            obj5.jsseId = 505;
            obj5.jsseStatus = "Draft";
            obj5.jsseDate = "09/20/2017";

            JSSEInfo obj6 = new JSSEInfo();
            obj6.jsseId = 506;
            obj6.jsseStatus = "Draft";
            obj6.jsseDate = "09/20/2017";


            JSSEInfo obj7 = new JSSEInfo();
            obj7.jsseId = 507;
            obj7.jsseStatus = "Submit";
            obj7.jsseDate = "09/20/2017";


            JSSEInfo obj8 = new JSSEInfo();
            obj8.jsseId = 508;
            obj8.jsseStatus = "Submit";
            obj8.jsseDate = "09/20/2017";


            JSSEInfo obj9 = new JSSEInfo();
            obj9.jsseId = 509;
            obj9.jsseStatus = "Draft";
            obj9.jsseDate = "09/20/2017";


            JSSEInfo obj10 = new JSSEInfo();
            obj10.jsseId = 510;
            obj10.jsseStatus = "Submit";
            obj10.jsseDate = "09/20/2017";


            JSSEInfo obj11 = new JSSEInfo();
            obj11.jsseId = 511;
            obj11.jsseStatus = "Draft";
            obj11.jsseDate = "09/20/2017";

            JSSEInfo obj12 = new JSSEInfo();
            obj12.jsseId = 512;
            obj12.jsseStatus = "Submit";
            obj12.jsseDate = "09/20/2017";


            JSSEInfo obj13 = new JSSEInfo();
            obj13.jsseId = 513;
            obj13.jsseStatus = "Draft";
            obj13.jsseDate = "09/20/2017";


            JSSEInfo obj14 = new JSSEInfo();
            obj14.jsseId = 514;
            obj14.jsseStatus = "Submit";
            obj14.jsseDate = "09/20/2017";


            JSSEInfo obj15 = new JSSEInfo();
            obj15.jsseId = 515;
            obj15.jsseStatus = "Draft";
            obj15.jsseDate = "09/20/2017";

            JSSEInfo obj16 = new JSSEInfo();
            obj16.jsseId = 516;
            obj16.jsseStatus = "Draft";
            obj16.jsseDate = "09/20/2017";

            JSSEInfo obj17 = new JSSEInfo();
            obj17.jsseId = 517;
            obj17.jsseStatus = "Submit";
            obj17.jsseDate = "09/20/2017";


            JSSEInfo obj18 = new JSSEInfo();
            obj18.jsseId = 518;
            obj18.jsseStatus = "Draft";
            obj18.jsseDate = "09/20/2017";


            JSSEInfo obj19 = new JSSEInfo();
            obj19.jsseId = 519;
            obj19.jsseStatus = "Submit";
            obj19.jsseDate = "09/20/2017";


            JSSEInfo obj20 = new JSSEInfo();
            obj20.jsseId = 520;
            obj20.jsseStatus = "Draft";
            obj20.jsseDate = "09/20/2017";

            JSSEInfo obj21 = new JSSEInfo();
            obj21.jsseId = 521;
            obj21.jsseStatus = "Draft";
            obj21.jsseDate = "09/20/2017";

            JSSEInfo obj22 = new JSSEInfo();
            obj22.jsseId = 522;
            obj22.jsseStatus = "Submit";
            obj22.jsseDate = "09/20/2017";


            JSSEInfo obj23 = new JSSEInfo();
            obj23.jsseId = 523;
            obj23.jsseStatus = "Draft";
            obj23.jsseDate = "09/20/2017";


            JSSEInfo obj24 = new JSSEInfo();
            obj24.jsseId = 524;
            obj24.jsseStatus = "Submit";
            obj24.jsseDate = "09/20/2017";


            JSSEInfo obj25 = new JSSEInfo();
            obj25.jsseId = 525;
            obj25.jsseStatus = "Draft";
            obj25.jsseDate = "09/20/2017";


            finalListObj.Add(obj);
            finalListObj.Add(obj1);
            finalListObj.Add(obj2);
            finalListObj.Add(obj3);
            finalListObj.Add(obj4);
            finalListObj.Add(obj5);
            finalListObj.Add(obj6);
            finalListObj.Add(obj7);
            finalListObj.Add(obj8);
            finalListObj.Add(obj9);
            finalListObj.Add(obj10);
            finalListObj.Add(obj11);
            finalListObj.Add(obj12);
            finalListObj.Add(obj13);
            finalListObj.Add(obj14);
            finalListObj.Add(obj15);
            finalListObj.Add(obj16);
            finalListObj.Add(obj17);
            finalListObj.Add(obj18);
            finalListObj.Add(obj19);
            finalListObj.Add(obj20);
            finalListObj.Add(obj21);
            finalListObj.Add(obj22);
            finalListObj.Add(obj23);
            finalListObj.Add(obj24);
            finalListObj.Add(obj25);


            ObservableCollection<JSSEInfo> localItemList = new ObservableCollection<JSSEInfo>();
            for (int i = 0; i < finalListObj.Count; i++){
                if (i < 8){
                    localItemList.Add(finalListObj[i]);
                }
            }

            ListeviewItemSource = localItemList;
            
        }

        Group selectedGroup;
        public Group SelectedGroup
        {
            get { return selectedGroup; }
            set
            {
                if (selectedGroup != value)
                {
                    selectedGroup = value;
                    SelectedGroupId = selectedGroup.Group_ID;
                    OnPropertyChanged("selectedGroup");
                }
            }
        }

        public void NextButtonClicked(int StartIndex, int lastObject){
            ObservableCollection<JSSEInfo> localItemList = new ObservableCollection<JSSEInfo>();
            for (int j = StartIndex; j < lastObject; j++)
                {
                if (j < finalListObj.Count)
                {
                    localItemList.Add(finalListObj[j]);
                }
                }
            ListeviewItemSource = localItemList;

        }

    
        public void PrevButtonClicked(int StartIndex, int lastObject)
        {
            ObservableCollection<JSSEInfo> localItemList = new ObservableCollection<JSSEInfo>();
            for (int j = StartIndex; j < lastObject; j++)
            {
                if (j < finalListObj.Count)
                {
                    localItemList.Add(finalListObj[j]);
                }
            }
            ListeviewItemSource = localItemList;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
