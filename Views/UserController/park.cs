
using SmartParking.Controllers;
using SmartParking.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Drawing;
using System;



namespace SmartParking.Views.UserController
{



public partial class park : UserControl
{
  readonly  reserver form4;
    checkout form5;
    recu form6;
    private static int nbrPanel = 1;
    Panel myPanel;
    Label myLabel;
    Reservation res;
    Ticket ticket;
    private List<Place> placeList;
    Panel b;
    int X = 3, Y = 3;
    List<Panel> panels = new List<Panel>();
    public park()
    {
        InitializeComponent();
        form4 = new reserver(this);
        form5 = new checkout(this);
        form6 = new recu(this);

    }
   
    private void initCapt()
    {
        placeList = PlaceControlle.afficher();
        foreach (Place item in placeList)
        {
            myPanel = new Panel();
            myPanel.Name = item.Code;
            myPanel.Location = new Point(X, Y);
            if (X < 819)
            {
                X = X + 102;
            }
            else
            {
                X = 3;
                Y = Y + 102;
            }
            myPanel.Size = new Size(96, 96);
            myPanel.BackColor = Color.Transparent;
            myPanel.BorderStyle = BorderStyle.Fixed3D;

            myLabel = new Label();
            myLabel.AutoSize = true;
            myLabel.BackColor = Color.Transparent;
            myLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            myLabel.ForeColor = Color.White;
            myLabel.Location = new Point(39, 54);
            myLabel.Name = "label1";
            myLabel.Size = new Size(44, 25);
            myLabel.TabIndex = 0;
            myLabel.Text = item.Code;
            myPanel.Controls.Add(myLabel);
            myPanel.Click += b_Click;
            myPanel.Cursor = Cursors.Hand;
            myPanel.BackgroundImageLayout = ImageLayout.Stretch;
            panels.Add(myPanel);
            panel1.Controls.Add(myPanel);

            if (item.Status == 0)
            {
                myPanel.BackgroundImage = Properties.Resources.icons8_parking_close;
            }
            else
            {
                myPanel.BackgroundImage = Properties.Resources.icons8_parking_96;
            }
            myPanel.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(myPanel);
            nbrPanel++;
        }
    }
    //orm4 reserve from5 form 3=>park 6recu  1 park
    private void Form3_Load(object sender, EventArgs e)
    {
        initCapt();
    }

    void b_Click(object sender, EventArgs e)
    {
        b = (Panel)sender;
        if (b != null)
        {
            Place pl = placeList.Find(x => x.Code == b.Name);

            if (pl.Status == 1)
            {
                form4.LabelCode = b.Name;
                if (form4.ShowDialog() == DialogResult.OK)
                {

                    if (pl != null)
                    {
                        res = new Reservation(form4.Matricule, form4.Fullname, form4.Model, "Auto", "3.00", System.DateTime.Now, form4.Cin, pl, 1);
                        ReservationControlle.AjouterReservation(res);

                        pl.Status = 0;
                        PlaceControlle.UpdatePlace(pl, pl.Id.ToString());

                        b.BackgroundImage = Properties.Resources.icons8_parking_close;
                    }
                    else
                    {
                        MessageBox.Show("introuvable");
                    }

                }
            }
            else
            {
                    Place p = PlaceControlle.FindByCode(b.Name);
                    MessageBox.Show(p.Id + ""); ;

                    res = ReservationControlle.CurrentRes(p);
                     MessageBox.Show(res.Id+"");
                form5.LabelCode = b.Name;
                form5.Matricule = res.Matricule;
                form5.Model = res.Model;
                form5.Cin = res.OwenerCin;
                form5.Fillname = res.Ownername;
                
                form5.DateD = res.DateEnreg;
                if (pl.Type == "Auto")
                    form5.Cost = 3;
                if (pl.Type == "Velo")
                    form5.Cost = 1;
                if (pl.Type == "Moto")
                    form5.Cost = 2;
                if (pl.Type == "Camion")
                    form5.Cost = 5;
               

                
                DialogResult dd = form5.ShowDialog();
                if (dd == DialogResult.OK)
                {

                    if (pl != null)
                    {
                        User u = new User(1,"Ahmed","Alaoui","Admin", "Ahmed", "1234", "cin123");
                        ticket = new Ticket(res, u, form5.DateF, form5.Total);

                        pl.Status = 1;
                        PlaceControlle.UpdatePlace(pl, pl.Id.ToString());

                        b.BackgroundImage = Properties.Resources.icons8_parking_96;
                        form6.Ticket = ticket;
                        form6.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("introuvable");
                    }

                }
                else if (dd == DialogResult.No)
                {
                    if (pl != null)
                    {
                        MessageBox.Show(res.Id.ToString());
                        ReservationControlle.SupprimerReservation(res.Id.ToString());

                        pl.Status = 1;
                        PlaceControlle.UpdatePlace(pl, pl.Id.ToString());

                        b.BackgroundImage = Properties.Resources.icons8_parking_96;
                    }
                    else
                    {
                        MessageBox.Show("introuvable");
                    }
                }
            }

        }
    }
}
    
}
