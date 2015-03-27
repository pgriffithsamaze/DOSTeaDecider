using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace GISTeaDecider
{
    public partial class TeaDecider : Form
    {
        public TeaDecider()
        {
            InitializeComponent();
        }

        Email Emailer = new Email();

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //***NUMBER RANGEs & WILDCARD CHOICE***//
            //James Wright - RANGE = 1-25 | WILDCARD = 13
            //Tom Bodington - RANGE = 26-50 | WILDCARD = 26
            //Paul Knight - RANGE = 51-75 | WILDCARD = 69 
            //Paul Griffiths - RANGE = 76-100 | WILDCARD = 100                       
            //James Wilkinson - RANGE = 101-125 | WILDCARD = 121            
            //Alessandro Scolozzi - RANGE = 126-150 | WILDCARD = 127
            //Dan Goodwin - RANGE = 151-175 | WILDCARD = 127
            //Charnelle Gibbon - RANGE = 176-200 | WILDCARD = 127
            //Amanda Follit - RANGE = 201-225| WILDCARD = 127


            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 200);
            //int randomNumber = 99;
            //int randomNumber = 216; 

            //Hide the picture boxes and info labels for each user 
            pbPersonImage.Image = Properties.Resources.Silhouette_question_mark;
            lblWildcardText.ForeColor = System.Drawing.Color.Black;
            lblResult.ForeColor = System.Drawing.Color.Black;
            lblWildcardText.Visible = false;
            lblResult.Visible = false;            
            lblEmailResult.Visible = false;
            lblResultMsg.Text = "";
            lblResultMsg.Visible = false;

            if (chkListIncluded.Items.Count > 0)
            {
                lblResult.Visible = true;
                lblResult.Text = randomNumber.ToString();

                //-----------------------------------------------------------Paul Griffiths details---------------------------------------------------------------------------//
                if ((randomNumber >= 76) && (randomNumber <= 100))
                {
                    //if this person is not in th eincluded list regenerate a new random number
                    if (!chkListIncluded.Items.Contains("Paul Griffiths"))
                    {
                        btnGenerate_Click(sender, e);
                        return;
                    }

                    //if this persons wilcard number is generated
                    if (randomNumber ==  100)
                    {
                        lblWildcardText.Visible = true;
                        lblResult.ForeColor = System.Drawing.Color.Red;
                        lblWildcardText.ForeColor = System.Drawing.Color.Red;
                        pbPersonImage.Image = Properties.Resources.paul_griff;
                        lblResultMsg.Visible = true;
                        lblResultMsg.Text = "Good news Paul! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                        if (Emailer.sendWildcardEmail("p.griffiths@amaze.com", "Paul"))
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "An email has been sent to p.griffiths@amaze.com";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;

                        }

                        //if the email is unsuccessfull update the email confirmation label
                        else
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "Error: the email was not sent";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;
                        }

                        return;

                    }

                    //email the brew list to the user and if its successfull update the email confirmation label
                    if (Emailer.sendEmail("p.griffiths@amaze.com", "Paul"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "The brew list has been emailed to p.griffiths@amaze.com";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    pbPersonImage.Image = Properties.Resources.paul_griff;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Bad times Paul! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                    return;
                }


                //-----------------------------------------------------------Paul Knight details---------------------------------------------------------------------------//
                if ((randomNumber >= 51) && (randomNumber <= 75))
                {
                    //if this person is not in th eincluded list regenerate a new random number
                    if (!chkListIncluded.Items.Contains("Paul Knight"))
                    {
                        btnGenerate_Click(sender, e);
                        return;
                    }

                    //if this persons wilcard number is generated
                    if (randomNumber == 69)
                    {
                        lblWildcardText.Visible = true;
                        lblResult.ForeColor = System.Drawing.Color.Red;
                        lblWildcardText.ForeColor = System.Drawing.Color.Red;
                        pbPersonImage.Image = Properties.Resources.paul_knight_001;
                        lblResultMsg.Visible = true;
                        lblResultMsg.Text = "Good news Paul! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                        if (Emailer.sendWildcardEmail("p.knight@amaze.com", "Paul"))
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "An email has been sent to p.knight@amaze.com";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;
                        }

                        //if the email is unsuccessfull update the email confirmation label
                        else
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "Error: the email was not sent";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;
                        }

                        return;
                    }

                    //email the brew list to the user and if its successfull update the email confirmation label
                    if (Emailer.sendEmail("p.knight@amaze.com", "Paul"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "The brew list has been emailed to p.knight@amaze.com ";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }
                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent:";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    pbPersonImage.Image = Properties.Resources.paul_knight_001;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Bad times Paul! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                    return;
                }

                //-----------------------------------------------------------James Wright details---------------------------------------------------------------------------//
                if ((randomNumber >= 1) && (randomNumber <= 25))
                {
                    //if this person is not in th eincluded list regenerate a new random number
                    if (!chkListIncluded.Items.Contains("James Wright"))
                    {
                        btnGenerate_Click(sender, e);
                        return;
                    }

                    //if this persons wilcard number is generated
                    if (randomNumber == 13)
                    {
                        lblWildcardText.Visible = true;
                        lblResult.ForeColor = System.Drawing.Color.Red;
                        lblWildcardText.ForeColor = System.Drawing.Color.Red;
                        pbPersonImage.Image = Properties.Resources.james_wright;
                        lblResultMsg.Visible = true;
                        lblResultMsg.Text = "Good news James! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                        //Send Email to James to notify him that his chosen wildcard number has been generated
                        if (Emailer.sendWildcardEmail("j.wright@amaze.com", "James"))
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "An email has been sent to j.wright@amaze.com";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;

                        }

                        //if the email is unsuccessfull update the email confirmation label
                        else
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "Error: the email was not sent";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;
                        }

                        return;
                        
                    }

                    //email the brew list to the user and if its successfull update the email confirmation label
                    if (Emailer.sendEmail("j.wright@amaze.com", "James"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "The brew list has been emailed to j.wright@amaze.com";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }
                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    pbPersonImage.Image = Properties.Resources.james_wright;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Bad times James! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                    return;
                }

                //-----------------------------------------------------------James Wilkinson details---------------------------------------------------------------------------//
                if ((randomNumber >= 101) && (randomNumber <= 125))
                {
                    //if this person is not in th eincluded list regenerate a new random number
                    if (!chkListIncluded.Items.Contains("James Wilkinson"))
                    {
                        btnGenerate_Click(sender, e);
                        return;
                    }

                    //if this persons wilcard number is generated
                    if (randomNumber == 121)
                    {
                        lblWildcardText.Visible = true;
                        lblResult.ForeColor = System.Drawing.Color.Red;
                        lblWildcardText.ForeColor = System.Drawing.Color.Red;
                        pbPersonImage.Image = Properties.Resources.james_wilkinson;
                        lblResultMsg.Visible = true;
                        lblResultMsg.Text = "Good news Jay! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                        //Send Email to Jay to notify him that his chosen wildcard number has been generated
                        if (Emailer.sendWildcardEmail("j.wilkinson@amaze.com", "Jay"))
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "An email has been sent to j.wilkinson@amaze.com";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;

                        }

                        //if the email is unsuccessfull update the email confirmation label
                        else
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "Error: the email was not sent";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;
                        }

                        return;

                    }

                    //email the brew list to the user and if its successfull update the email confirmation label
                    if (Emailer.sendEmail("j.wilkinson@amaze.com", "Jay"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "The brew list has been emailed to j.wilkinson@amaze.com";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }
                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    //display James's Information
                    pbPersonImage.Image = Properties.Resources.james_wilkinson;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Bad times Jay! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                    return;

                }

                //-----------------------------------------------------------Tom Bodington details---------------------------------------------------------------------------//
                if ((randomNumber >= 26) && (randomNumber <= 50))
                {
                    //if this person is not in th eincluded list regenerate a new random number
                    if (!chkListIncluded.Items.Contains("Tom Bodington"))
                    {
                        btnGenerate_Click(sender, e);
                        return;
                    }

                    //if this persons wilcard number is generated
                    if (randomNumber == 26)
                    {
                        lblWildcardText.Visible = true;
                        lblResult.ForeColor = System.Drawing.Color.Red;
                        lblWildcardText.ForeColor = System.Drawing.Color.Red;
                        pbPersonImage.Image = Properties.Resources.tom_bodington_001;
                        lblResultMsg.Visible = true;
                        lblResultMsg.Text = "Good news Tom! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                        //Send Email to Tom to notify him that his chosen wildcard number has been generated
                        if (Emailer.sendWildcardEmail("t.bodington@amaze.com", "Tom"))
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "An email has been sent to t.bodington@amaze.com";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;

                        }

                        //if the email is unsuccessfull update the email confirmation label
                        else
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "Error: the email was not sent";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;
                        }

                        return;

                    }

                    //if the email is sent 
                    if (Emailer.sendEmail("t.bodington@amaze.com", "Tom"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "The brew list has been emailed to t.boddingtom@amaze.com";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }
                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    pbPersonImage.Image = Properties.Resources.tom_bodington_001;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Bad times Tom! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                    return;
                }

                //-----------------------------------------------------------Alessandro Scolozzi details---------------------------------------------------------------------------//
                if ((randomNumber >= 126) && (randomNumber <= 150))
                {
                    if (!chkListIncluded.Items.Contains("Alessandro Scolozzi"))
                    {
                        btnGenerate_Click(sender, e);
                        return;
                    }

                    //if this persons wilcard number is generated
                    if (randomNumber == 127)
                    {
                        lblWildcardText.Visible = true;
                        lblResult.ForeColor = System.Drawing.Color.Red;
                        lblWildcardText.ForeColor = System.Drawing.Color.Red;
                        pbPersonImage.Image = Properties.Resources.alessandro_scolozzi;
                        lblResultMsg.Visible = true;
                        lblResultMsg.Text = "Good news Alessandro! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                        //Send Email to alessandro to notify him that his chosen wildcard number has been generated
                        if (Emailer.sendWildcardEmail("a.scolozzi.com", "Alessandro"))
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "An email has been sent to a.scolozzi.com";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;

                        }

                                            //if the email is unsuccessfull update the email confirmation label
                        else
                        {
                            lblEmailResult.Visible = true;
                            lblEmailResult.Text = "Error: the email was not sent";
                            lblEmailResult.ForeColor = System.Drawing.Color.Red;
                        }

                        return;
                    }

                    //email the brew list to the user and if its successfull update the email confirmation label
                    if (Emailer.sendEmail("a.scolozzi@amaze.com", "Alessandro"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "The brew list has been emailed to a.scolozzi@amaze.com";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }
                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    pbPersonImage.Image = Properties.Resources.alessandro_scolozzi;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Bad times Alessandro! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                    return;
                }
            }

            else
            {
                //alert the user that at least one team member must be included before generating
                MessageBox.Show("Please add at least one team member to the included list before generating", "Select Team member(s)");
                return;
            }



            //-----------------------------------------------------------Dan Goodwin details---------------------------------------------------------------------------//
            if ((randomNumber >= 151) && (randomNumber <= 175))
            {
                //if this person is not in th eincluded list regenerate a new random number
                if (!chkListIncluded.Items.Contains("Dan Goodwin"))
                {
                    btnGenerate_Click(sender, e);
                    return;
                }

                //if this persons wilcard number is generated
                if (randomNumber == 160)
                {
                    lblWildcardText.Visible = true;
                    lblResult.ForeColor = System.Drawing.Color.Red;
                    lblWildcardText.ForeColor = System.Drawing.Color.Red;
                    pbPersonImage.Image = Properties.Resources.daniel_goodwin;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Good news Dan! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                    if (Emailer.sendWildcardEmail("d.goodwin@amaze.com", "Dan"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "An email has been sent to d.goodwin@amaze.com";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;

                    }

                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    return;

                }

                //email the brew list to the user and if its successfull update the email confirmation label
                if (Emailer.sendEmail("d.goodwin@amaze.com", "Dan"))
                {
                    lblEmailResult.Visible = true;
                    lblEmailResult.Text = "The brew list has been emailed to d.goodwin@amaze.com";
                    lblEmailResult.ForeColor = System.Drawing.Color.Red;
                }

                //if the email is unsuccessfull update the email confirmation label
                else
                {
                    lblEmailResult.Visible = true;
                    lblEmailResult.Text = "Error: the email was not sent";
                    lblEmailResult.ForeColor = System.Drawing.Color.Red;
                }

                pbPersonImage.Image = Properties.Resources.daniel_goodwin;
                lblResultMsg.Visible = true;
                lblResultMsg.Text = "Bad times Dan! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                return;
            }

            //-----------------------------------------------------------Charnelle Gibbon details---------------------------------------------------------------------------//
            if ((randomNumber >= 176) && (randomNumber <= 200))
            {
                //if this person is not in th eincluded list regenerate a new random number
                if (!chkListIncluded.Items.Contains("Charnelle Gibbon"))
                {
                    btnGenerate_Click(sender, e);
                    return;
                }

                //if this persons wilcard number is generated
                if (randomNumber == 199)
                {
                    lblWildcardText.Visible = true;
                    lblResult.ForeColor = System.Drawing.Color.Red;
                    lblWildcardText.ForeColor = System.Drawing.Color.Red;
                    pbPersonImage.Image = Properties.Resources.charnelle_gibbon;
                    lblResultMsg.Visible = true;
                    lblResultMsg.Text = "Good news Charnelle! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

                    if (Emailer.sendWildcardEmail("c.gibbon@amaze.com", "Charnelle"))
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "An email has been sent to c.gibbon@amaze.com";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;

                    }

                    //if the email is unsuccessfull update the email confirmation label
                    else
                    {
                        lblEmailResult.Visible = true;
                        lblEmailResult.Text = "Error: the email was not sent";
                        lblEmailResult.ForeColor = System.Drawing.Color.Red;
                    }

                    return;

                }

                //email the brew list to the user and if its successfull update the email confirmation label
                if (Emailer.sendEmail("c.gibbon@amaze.com", "Charnelle"))
                {
                    lblEmailResult.Visible = true;
                    lblEmailResult.Text = "The brew list has been emailed to c.gibbon@amaze.com";
                    lblEmailResult.ForeColor = System.Drawing.Color.Red;
                }

                //if the email is unsuccessfull update the email confirmation label
                else
                {
                    lblEmailResult.Visible = true;
                    lblEmailResult.Text = "Error: the email was not sent";
                    lblEmailResult.ForeColor = System.Drawing.Color.Red;
                }

                pbPersonImage.Image = Properties.Resources.charnelle_gibbon;
                lblResultMsg.Visible = true;
                lblResultMsg.Text = "Bad times Charnelle! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
                return;
            }


            //-----------------------------------------------------------Amanda Follit details---------------------------------------------------------------------------//
            //if ((randomNumber >= 201) && (randomNumber <= 225))
            //{
            //    //if this person is not in th eincluded list regenerate a new random number
            //    if (!chkListIncluded.Items.Contains("Amanda Follit"))
            //    {
            //        btnGenerate_Click(sender, e);
            //        return;
            //    }

            //    //if this persons wilcard number is generated
            //    if (randomNumber == 220)
            //    {
            //        lblWildcardText.Visible = true;
            //        lblResult.ForeColor = System.Drawing.Color.Red;
            //        lblWildcardText.ForeColor = System.Drawing.Color.Red;
            //        pbPersonImage.Image = Properties.Resources.amanda_follit;
            //        lblResultMsg.Visible = true;
            //        lblResultMsg.Text = "Good news Amanda! \n \nThe GIS Tea Decider has randomly generated your wild card \nnumber. The power is now in your hands, choose the person \nthat you would like to make the brews instead of you. ";

            //        if (Emailer.sendWildcardEmail("a.follit@amaze.com", "Amanda"))
            //        {
            //            lblEmailResult.Visible = true;
            //            lblEmailResult.Text = "An email has been sent to a.follit.com";
            //            lblEmailResult.ForeColor = System.Drawing.Color.Red;

            //        }

            //        //if the email is unsuccessfull update the email confirmation label
            //        else
            //        {
            //            lblEmailResult.Visible = true;
            //            lblEmailResult.Text = "Error: the email was not sent";
            //            lblEmailResult.ForeColor = System.Drawing.Color.Red;
            //        }

            //        return;

            //    }

            //    //email the brew list to the user and if its successfull update the email confirmation label
            //    if (Emailer.sendEmail("a.follit@amaze.com", "Amanda"))
            //    {
            //        lblEmailResult.Visible = true;
            //        lblEmailResult.Text = "The brew list has been emailed to a.follit@amaze.com";
            //        lblEmailResult.ForeColor = System.Drawing.Color.Red;
            //    }

            //    //if the email is unsuccessfull update the email confirmation label
            //    else
            //    {
            //        lblEmailResult.Visible = true;
            //        lblEmailResult.Text = "Error: the email was not sent";
            //        lblEmailResult.ForeColor = System.Drawing.Color.Red;
            //    }

            //    pbPersonImage.Image = Properties.Resources.amanda_follit;
            //    lblResultMsg.Visible = true;
            //    lblResultMsg.Text = "Bad times Amanda! \n \nThe GIS Tea Decider has randomly generated a number \nbetween your range. The only thing left to do is to get your \narse in to that kitchen and brew up for the team!";
            //    return;
            //}
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if no members have been checked alert the user
            if (chkListTeam.CheckedItems.Count == 0)
            {
                MessageBox.Show("No members selected, please check the members you want to include", "Select Team member(s)");
                return;
            }

            else
            {
                //add each person who has been checked to the list
                foreach (var itemChecked in chkListTeam.CheckedItems)
                {
                    //check if the person already been added to the list 
                    if (!chkListIncluded.Items.Contains(itemChecked))
                    {
                        chkListIncluded.Items.Add(itemChecked.ToString());
                        chkListTeam.Items.Remove(itemChecked.ToString());

                    }

                }

                //loop through the team members and remove the check once they have been included
                for (int i = 0; i < chkListTeam.Items.Count; i++)
                {
                    chkListTeam.SetItemChecked(i, false);
                }
            }

        }


        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (chkListTeam.Items.Count > 0)
            {
                //check all team members that are in the list 
                for (int i = 0; i < chkListTeam.Items.Count; i++)
                {
                    chkListTeam.SetItemChecked(i, true);
                }

            }

            else
            {   //display friendly error to the user 
                MessageBox.Show("There are no team members checked to be added to the included members list", "No member(s) checked");
            }

        }


        private void btnDeselectAllIncluded_Click_1(object sender, EventArgs e)
        {
            if (chkListIncluded.CheckedItems.Count == 0)
            {
                //if no memebrs have been checked
                MessageBox.Show("There are no team members checked to be added to the included members list", "No member(s) checked");
                return;
            }
            else
            {
                //loop through each user in the team list and deselect them
                for (int i = 0; i < chkListIncluded.Items.Count; i++)
                {
                    chkListIncluded.SetItemChecked(i, false);
                }
            }

            ////remove any members that have been added to the included list
            //if (chkListIncluded.Items.Count > 0)
            //{
            //    //check all team members that are in the included list 
            //    for (int i = 0; i < chkListIncluded.Items.Count; i++)
            //    {
            //        chkListIncluded.SetItemChecked(i, true);
            //    }

            //    //for each user selected in the included list remove them and add them back in the team member list
            //    foreach (var itemSelected in chkListIncluded.CheckedItems.OfType<String>().ToList())
            //    {
            //        chkListIncluded.Items.Remove(itemSelected);
            //        chkListTeam.Items.Add(itemSelected.ToString());
            //    }
            //    //chkListIncluded.Items.Clear();
            //    //chkListTeam.Items.Add();
            //}

            //else
            //{
            //    //if no memebrs have been added in alert the user
            //    MessageBox.Show("There are no included members to remove", "No included member(s)");

            //}

        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            if (chkListTeam.CheckedItems.Count == 0)
            {
                //if no memebrs have been checked
                MessageBox.Show("There are no team members checked to be added to the included members list", "No member(s) checked");
                return;
            }
            else
            {
                //loop through each user in the team list and deselect them
                for (int i = 0; i < chkListTeam.Items.Count; i++)
                {
                    chkListTeam.SetItemChecked(i, false);
                }
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (chkListIncluded.CheckedItems.Count == 0)
            {
                //if no memebrs have been checked
                MessageBox.Show("There are no team members checked to be removed from the included members list", "No member(s) checked");
                return;
            }
            else
            {
                //for each checked user in the included list remove them and add them into the team member list
                foreach (var itemSelected in chkListIncluded.CheckedItems.OfType<String>().ToList())
                {
                    chkListIncluded.Items.Remove(itemSelected);
                    chkListTeam.Items.Add(itemSelected.ToString());
                }
            }

        }

        private void btnSelectAllIncluded_Click(object sender, EventArgs e)
        {
            if (chkListIncluded.Items.Count > 0)
            {
                //loop through each user in the team list and deselect them
                for (int i = 0; i < chkListIncluded.Items.Count; i++)
                {
                    chkListIncluded.SetItemChecked(i, true);
                }
                
            }
            else
            {
                //if no memebrs have been checked
                MessageBox.Show("There are no team members checked to be removed to the included members list", "No member(s) checked");
                return;
            }
        }


    }
}


