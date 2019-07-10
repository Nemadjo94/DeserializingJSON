using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deserializing_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region UI events

        private void clearDebug_Click(object sender, EventArgs e)
        {
            jsonOutputBox.Text = string.Empty;
        }

        private void deserialize_Click_1(object sender, EventArgs e)
        {
            //debugOutput(jsonInputBox.Text);
            deserializeJSON(jsonInputBox.Text);
        }

        private void cmdClearInput_Click(object sender, EventArgs e)
        {
            jsonInputBox.Text = string.Empty;
        }

        #endregion

        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                jsonOutputBox.Text = jsonOutputBox.Text + strDebugText + Environment.NewLine;
                jsonOutputBox.SelectionStart = jsonOutputBox.TextLength;
                jsonOutputBox.ScrollToCaret();

            }
            catch(Exception exc)
            {
                System.Diagnostics.Debug.Write(exc.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion

        private void jsonOutputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region json functions

        private void deserializeJSON(string strJSON)
        {
            try
            {
                var test = JsonConvert.DeserializeObject<dynamic>(strJSON);
                double number = 45.2389365210;
                double[] lat_list = new double[test.stops.Count];
                // debugOutput(test.lines[0].name.ToString());
                for (int i = 0; i < lat_list.Length; i++){

                    lat_list[i] = test.stops[i].lat;
                }
                double closest = lat_list.OrderBy(item => Math.Abs(number - item)).First();
                debugOutput(closest.ToString());

               // debugOutput(lat_list[0].ToString());
                

                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                var jPerson2 = JsonConvert.DeserializeObject<jsonPersonSimple>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonComplex>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonArray>(strJSON);

                debugOutput("Here's our JSON object: " + jPerson2.ToString());             
                //debugOutput("Here's the First Name: " + jPerson.firstName);
                //debugOutput("Here's the Last Name: " + jPerson.lastName);
                //debugOutput("Hese's the Street Address: " + jPerson.address.streetAddress);
                //debugOutput("Attempting to print phone numbers....");

                //foreach(var num in jPerson.PhoneNumbers)
                //{
                //    debugOutput(num.type.ToString() + " : " + num.number.ToString());
                //}
            }
            catch (Exception exc)
            {
                debugOutput("We had a problem: " + exc.Message.ToString());
            }
        }

        #endregion

        
    }
}
