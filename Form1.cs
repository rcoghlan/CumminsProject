using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace Cummins_Final_Project
{
    public partial class ee : Form
    {
        public ee()
        {
            InitializeComponent();

            //loginPage.Visible = true;
            //faultPanel.Visible = false;
            //loginPage.Show();
            welcomeLabel.Font = new Font("Arial", 30);
            //faultPanel.Font = new Font("Arial", 30);
            errorlabel1.Font = new Font("Arial", 30);


        }

        private void ee_Load(object sender, EventArgs e)
        {


        }


        public static object Evaluate(Expression e)
        {
            if (e.NodeType == ExpressionType.Constant)
                return ((ConstantExpression)e).Value;
            return Expression.Lambda(e).Compile().DynamicInvoke();
        }

        public string fc { get; set; }


        private void FillNode(List<ItemInfo> items, TreeNode node)
            {
                var parentID = node != null
                    ? (int)node.Tag
                    : 0;

                var nodesCollection = node != null
                   ? node.Nodes
                   : tvw_display.Nodes;


                foreach (var item in items.Where(i => i.ParentID == parentID))
                {
                    var newNode = nodesCollection.Add(item.Name, item.Name);
                    newNode.Tag = item.ID;
                    FillNode(items, newNode);
                }
            }


        private void viewBttn_Click(object sender, EventArgs e)
        {
            faultPanel.Hide();
        }



        //Dynamic function for reading in initial fault code data to the interface
        private void readData_Click(object sender, EventArgs e)
        {
           

            string content = null;


            //Read json 
            //using (StreamReader sr = new StreamReader(@"C:\Users\Ryan\source\repos\Cummins_Final_Project\Cummins_Final_Project\bin\Debug\test1.json"))

            //{
            //    content = sr.ReadToEnd();

            //}


            List<FaultData> faultData = JsonConvert.DeserializeObject<List<FaultData>>(content);

         

            foreach (var item in faultData)

            {
                faultCodeListBox.Items.Add(item);
                faultCodeListBox.DataSource = faultData;
                faultCodeListBox.DisplayMember = "FaultCode";
            }


            foreach (var item in faultData)
            {
                timeSumListBox.Items.Add(item);
                timeSumListBox.DataSource = faultData;
                timeSumListBox.DisplayMember = "TimeSummary";
            }




            foreach (var item in faultData)
            {
                runTime.Items.Add(item);
                runTime.DataSource = faultData;
                runTime.DisplayMember = "RunTime";
            }



            foreach (var item in faultData)
            {
                serialNum.Items.Add(item);
                serialNum.DataSource = faultData;
                serialNum.DisplayMember = "ESN";
            }

            foreach (var item in faultData)
            {
                dateListBox.Items.Add(item);
                dateListBox.DataSource = faultData;
                dateListBox.DisplayMember = "Date";
            }


            foreach (var item in faultData)
            {
                descriptListBox.Items.Add(item);
                descriptListBox.DataSource = faultData;
                descriptListBox.DisplayMember = "Description";
            }


            foreach (var item in faultData)
            {
                detectedListbox.Items.Add(item);
                detectedListbox.DataSource = faultData;
                detectedListbox.DisplayMember = "Detected";
            }

           

            //procedureLabel.Text = faultCodeListBox.Items.ToString();
        }


        private void beginDiag_Click(object sender, EventArgs e)
        {
           

            var items = new List<ItemInfo>()
                {//root Node 
                 new ItemInfo(){ID = 1, ParentID = 0, Name = "Begin Diagnostic Procedure", Question = "" },

                 new ItemInfo(){ID = 2, ParentID = 1, Name = "What fault code?",Question = "" },

                 new ItemInfo(){ID = 3, ParentID = 2, Name = "FC135",Question = "" },

                 new ItemInfo(){ID = 4, ParentID = 3, Name = "When",Question = "" },

                 new ItemInfo(){ID = 5, ParentID = 4, Name = "Driving",Question = "" },

                 new ItemInfo(){ID = 6, ParentID = 4, Name = "During Maintenance",Question = "" },

                 new ItemInfo(){ID = 7, ParentID = 5, Name = "Where",Question = "" },

                 new ItemInfo(){ID = 8, ParentID = 7, Name = "Engine",Question = "" },

                 new ItemInfo(){ID = 9, ParentID = 8, Name = "Retreiving Possible Solutions.....",Question = "" },

                 new ItemInfo(){ID = 10, ParentID = 9, Name = "Main Bearing",Question = "" },

                 new ItemInfo(){ID = 11, ParentID = 10, Name = "Is there an excessive bearing clearance?",Question = "" },

                 new ItemInfo(){ID = 12, ParentID = 11, Name = "Yes",Question = "" },

                 new ItemInfo(){ID = 13, ParentID = 11, Name = "No",Question = "" },

                 new ItemInfo(){ID = 14, ParentID = 12, Name = "Reduce the oil clearance between the rod and main bearings and crankshaft",Question = "" },

                 new ItemInfo(){ID = 15, ParentID = 13, Name = "Check Oil Pump",Question = "" },

                 new ItemInfo(){ID = 16, ParentID = 15, Name = "Is there a problem with the oil pump?",Question = "" },

                 new ItemInfo(){ID = 17, ParentID = 16, Name = "Yes",Question = "" },

                 new ItemInfo(){ID = 18, ParentID = 17, Name = "Retreiving Possible Solutions.....",Question = "" },

                 new ItemInfo(){ID = 19, ParentID = 18, Name = "Oil pump cover bent",Question = "" },

                 new ItemInfo(){ID = 20, ParentID = 19, Name = "Straighten out bent oil cover",Question = "" },

                 new ItemInfo(){ID = 21, ParentID = 14, Name = "Oil pump cover cracked",Question = "" },

                 new ItemInfo(){ID = 22, ParentID = 21, Name = "Is it sealable?",Question = "" },

                 new ItemInfo(){ID = 23, ParentID = 22, Name = "Yes",Question = "" },

                  new ItemInfo(){ID = 24, ParentID = 22, Name = "No",Question = "" },

                 new ItemInfo(){ID = 25, ParentID = 23, Name = "Seal oil pump cover",Question = "" },

                 new ItemInfo(){ID = 26, ParentID = 24, Name = "No",Question = "" },

                 new ItemInfo(){ID = 27, ParentID = 26, Name = "Replace oil pump",Question = "" },

                 new ItemInfo(){ID = 28, ParentID = 18, Name = "Oil pump cover worn",Question = "" },

                 new ItemInfo(){ID = 29, ParentID = 22, Name = "Replace oil pump cover",Question = "" },

                 new ItemInfo(){ID = 30, ParentID = 16, Name = "No",Question = "" },

                 new ItemInfo(){ID = 31, ParentID = 30, Name = "Check oil pressure switch",Question = "" },

                 new ItemInfo(){ID = 32, ParentID = 31, Name = "Is there a problem with the oil pressure switch",Question = "" },

                 new ItemInfo(){ID = 33, ParentID = 32, Name = "Yes",Question = "" },

                 new ItemInfo(){ID = 34, ParentID = 33, Name = "No",Question = "" },

                 new ItemInfo(){ID = 35, ParentID = 32, Name = "Retreiving Possible Solution.....",Question = "" },

                 new ItemInfo(){ID = 36, ParentID = 35, Name = "Worn connected oil pressure switch",Question = "" },

                 new ItemInfo(){ID = 37, ParentID = 35, Name = "Loose connection on oil pressure switch",Question = "" },

                 new ItemInfo(){ID = 38, ParentID = 36, Name = "Replace connected oil pressure switch",Question = "" },

                 new ItemInfo(){ID = 39, ParentID = 37, Name = "Repair Connection of oil pressure switch",Question = "" },

                 new ItemInfo(){ID = 40, ParentID = 34, Name = "Validate Oil Crankers Type and weight",Question = "" },

                 new ItemInfo(){ID = 41, ParentID = 40, Name = "Is there a problem with the oil crankcase type or weight?",Question = "" },

                 new ItemInfo(){ID = 42, ParentID = 41, Name = "Yes",Question = "" },

                 new ItemInfo(){ID = 43, ParentID = 41, Name = "No",Question = "" },

                 new ItemInfo(){ID = 44, ParentID = 42, Name = "Retreiving Possible Solutions.....",Question = "" },

                 new ItemInfo(){ID = 45, ParentID = 42, Name = "Incorrent grade of motor oil",Question = "" },

                 new ItemInfo(){ID = 46, ParentID = 43, Name = "Replace incorrect grade of motor oil",Question = "" },

                 new ItemInfo(){ID = 47, ParentID = 43, Name = "Check oil filter",Question = "" },

                 new ItemInfo(){ID = 48, ParentID = 47, Name = "Is there a problem with the oil filter?",Question = "" },

                 new ItemInfo(){ID = 49, ParentID = 48, Name = "Yes",Question = "" },

                 new ItemInfo(){ID = 50, ParentID = 49, Name = "No",Question = "" },

                 new ItemInfo(){ID = 51, ParentID = 49, Name = "Retreiving Possible Solutions.....",Question = "" },

                 new ItemInfo(){ID = 52, ParentID = 51, Name = "Old oil filter",Question = "" },

                 new ItemInfo(){ID = 53, ParentID = 52, Name = "Change oil filter",Question = "" },

                 new ItemInfo(){ID = 54, ParentID = 51, Name = "Clogged oil filter",Question = "" },

                 new ItemInfo(){ID = 55, ParentID = 54, Name = "Unclog oil filter",Question = "" },

                 new ItemInfo(){ID = 56, ParentID = 55, Name = "Refer to SMN to report unfound event",Question = "" },

                 new ItemInfo(){ID = 56, ParentID = 6, Name = "CDS - Time or Activity deemed irrelevant to this fault code.",Question = "" },


             };

            FillNode(items, null);



        }


        private void viewFaults_Click(object sender, EventArgs e)
        {

            string content = null;


            //Read json 
            using (StreamReader sr = new StreamReader(@"C:\Users\Ryan\Desktop\Cummins_Final_Project\Cummins_Final_Project\bin\Debug\test1.json"))

            {
                content = sr.ReadToEnd();

            }


            List<FaultData> faultData = JsonConvert.DeserializeObject<List<FaultData>>(content);



            foreach (var item in faultData)

            {
                faultCodeListBox.Items.Add(item);
                faultCodeListBox.DataSource = faultData;
                faultCodeListBox.DisplayMember = "FaultCode";
            }


            foreach (var item in faultData)
            {
                timeSumListBox.Items.Add(item);
                timeSumListBox.DataSource = faultData;
                timeSumListBox.DisplayMember = "TimeSummary";
            }




            foreach (var item in faultData)
            {
                runTime.Items.Add(item);
                runTime.DataSource = faultData;
                runTime.DisplayMember = "RunTime";
            }



            foreach (var item in faultData)
            {
                serialNum.Items.Add(item);
                serialNum.DataSource = faultData;
                serialNum.DisplayMember = "ESN";
            }

            foreach (var item in faultData)
            {
                dateListBox.Items.Add(item);
                dateListBox.DataSource = faultData;
                dateListBox.DisplayMember = "Date";
            }


            foreach (var item in faultData)
            {
                descriptListBox.Items.Add(item);
                descriptListBox.DataSource = faultData;
                descriptListBox.DisplayMember = "Description";
            }


            foreach (var item in faultData)
            {
                detectedListbox.Items.Add(item);
                detectedListbox.DataSource = faultData;
                detectedListbox.DisplayMember = "Detected";
            }



            //procedureLabel.Text = faultCodeListBox.Items.ToString();
        }

        private void runNew_Click(object sender, EventArgs e)
        {

            


        }

        private void loginBttn_Click(object sender, EventArgs e)
        {
            loginPage.Visible = false;
            
        }

        private void userEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void passEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
