using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Test_1
{
    public partial class Form1 : Form
    {
        //Declaring variables that will allow us to connect the form to the database
        MongoClient mgoClient;
        IMongoDatabase mgoDatabase;
        IMongoCollection<Identity> mgoCollection;

        public Form1()
        {
            InitializeComponent(); 

            //Using the declared variables above to connect to the database
            mgoClient = new MongoClient("mongodb+srv://dblUserLekelela:Admin1@maincluster.nvdd2.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            mgoDatabase = mgoClient.GetDatabase("Particulars");
            mgoCollection = mgoDatabase.GetCollection<Identity>("Identity");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This code will close the form when the user preseses cancel 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variebles
            bool blnValidInput = true;

            blnValidInput = ValidateInput(blnValidInput);

            //this if an statement that will take place when the input is valid 
            if (blnValidInput == true)
            {
                
               Identity identity = new Identity(); //this code declares identity class in this form 

               //the follwoing  code assigns the identity fields data that will be entered by the user 
               identity.strName = txtbxName.Text;
               identity.strSurname = txtbxSurname.Text;
               identity.str_ID = txtbxIDnumber.Text;
               identity.strDate = DateOfBirthTimepicker.ToString();

                
                //This code finds if the id exist in the database
                var filter_ID = Builders<Identity>.Filter.Eq("Identity number", identity.str_ID);
                var IdNumber = mgoCollection.Find(filter_ID).FirstOrDefault();

                if (IdNumber == null)
                {
                    mgoCollection.InsertOne(identity);//inserting data in the intp the identity class

                    //Showing message that is confirming that data has data has been posted
                    MessageBox.Show("Data posted succcessfully");
                }
                else
                {
                    MessageBox.Show("ID number already exist");
                }
                         
            }
          

        }

        public bool ValidateInput(bool blnValidInput)
        {
            //This code validates date of birth format
            if (DateOfBirthTimepicker.Value.ToString() == "")
            {
                MessageBox.Show("Please select password");
                blnValidInput = false;
            }

            //This code validates if there has been entered in the name textbox
            if (txtbxName.Text == "")
            {
                MessageBox.Show("Please enter your name!");
                blnValidInput = false;
            }

            // we are doing the  same thing as above
            if (txtbxSurname.Text == "")
            {
                MessageBox.Show("Please enter your surname!");
                blnValidInput = false;
            }

            // This code validates the ID number if it is valid  
            if (txtbxIDnumber.Text.Length != 13)
            {
                MessageBox.Show("Please enter a valid ID number");
                blnValidInput = false;
            }
            return blnValidInput;
        }
    }
}



