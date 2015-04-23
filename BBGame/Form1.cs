using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiimoteLib;

namespace BBGame
{
    public partial class Form1 : Form
    {
        //WiimoteLib.Wiimote wm = new WiimoteLib.WiiMote();

        string naam;

        Single xPosBol = 0;
        Single yIndexBol = 0;
        int speelveldBreedte = 720;
        ArrayList pixels = new ArrayList();
        int lineFragmentLength;
        int straatBreedte = 400;
        int pixelArraySize;


        Graphics g;
        Pen bic = new Pen(Color.White, 20);
        Timer tmrMain;
        Timer tmrScore;
        int spelduur = 0;

        int score;
    
        int levens = 100;

        void InitWiiStuff()
        {
            var wm = new Wiimote();
            var wm2 = new Wiimote();
            wm.WiimoteChanged += wm_WiimoteChanged;

            wm.WiimoteExtensionChanged += wm_WiimoteExtensionChanged;
            wm.Connect();

            wm.SetReportType(WiimoteLib.InputReport.ButtonsAccel, true);
        }

        void wm_WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs e)
        {
            If args.Inserted Then
    //        wm.SetReportType(WiimoteLib.InputReport.IRExtensionAccel, True) ' return extension data
    //    Else
    //        wm.SetReportType(WiimoteLib.InputReport.IRAccel, True) ' back to original mode
    //    End If
            
            throw new NotImplementedException();
        }

        void wm_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
    //    Dim ws As WiimoteState = args.WiimoteState

    //    ' write out the state of the A button    
    //    If ws.ExtensionType = ExtensionType.BalanceBoard Then

    //        xPosBol = Math.Truncate((ws.BalanceBoardState.CenterOfGravity.X / 15) * speelveldBreedte)
    //        ' ws.BalanceBoardState.WeightKg
    //        ' 80 kg = 15
    //        ' 65 kg = 10


    //        'y = Math.Truncate(ws.BalanceBoardState.CenterOfGravity.Y)

    //        'Dim x1 As Double = Double.Parse(x)
    //        'Dim y1 As Double = Double.Parse(y)
    //    End If

            throw new NotImplementedException();
        }

        void InitFormsStuff()
        {
        //    //' zet volledig venster in midden van scherm
        //Me.Location = New System.Drawing.Point((My.Computer.Screen.WorkingArea.Width / 2) - Me.Width / 1.35, 1)

        //Me.Size = New Size(1400, 800)

        pnlSpeelveld.Location = new System.Drawing.Point(1, 1);
        pnlSpeelveld.Size = new Size(1280, speelveldBreedte);

        //lblScoreInfo.Location = New System.Drawing.Point(1300, 20)
        //lblScore.Location = New System.Drawing.Point(1300, 40)
        //lblLevenInfo.Location = New System.Drawing.Point(1300, 100)
        //lblLeven.Location = New System.Drawing.Point(1300, 120)


        //' TODO
        //lblProcent.Visible = False
        //lblProcent.Location = New System.Drawing.Point(200, 735)
        }

        public Form1()
        {
            InitializeComponent();

        //    MainForm.Hide()
            InitWiiStuff();
            InitFormsStuff();

            lineFragmentLength = 10;
            lblLeven.Text = levens.ToString & " %";

            pixelArraySize = (pnlSpeelveld.Height / lineFragmentLength);

            // Vul startpixels:
            for(int i =0; i<pixelArraySize; i++)
            {
                pixels.Add((pnlSpeelveld.Width / 2) - straatBreedte);
            }
            
            tmrMain.Interval = 50;
            tmrMain.Enabled = true;
            tmrScore.Interval = 200;
            tmrScore.Enabled = true;
        }


    //    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
    //    Dim rnd As New Random

    //    UpdatePixels()
    //    DetectCollisions()
    //    CheckLeven()
    //    If levens <= 0 Then
    //        MessageBox.Show("Game Over")
    //        GameOver()
    //    End If
    //    If score > 0 And score Mod 20 = 0 Then
    //        straatBreedte -= 1
    //    End If
    //    lblScore.Text = score.ToString()

    //    pnlSpeelveld.Refresh()



    //    'Beperking invoegen zodat straatbreedte niet negatief kan worden
    //    ' om de 1000 punten wordt straatbreedte 10% kleiner

    //    ' TODO lblLevenFlits
    //    'If lblScore.Text Mod 100 = 0 Then
    //    '    lblLevenFlits.Text = "U heeft nog " & levens.ToString & " levens over!"
    //    '    lblLevenFlits.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))

    //    '    lblLevenFlits.Visible = True
    //    '    levens -= 1
    //    '    lblLeven.Text = levens
    //    'End If

    //End Sub

    //Sub GameOver()
    //    naam = InputBox("Je behaalde " & score & " punten!. Proficiat." & vbCrLf & vbCrLf & "Geef je naam in aub:", "Game Over!")
    //    frmScore.Show()
    //End Sub

    //Sub CheckLeven()
    //    If levens <= 0 Then
    //        tmrMain.Stop()
    //        tmrScore.Stop()
    //    End If
    //End Sub

    //Private Sub tmrScore_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScore.Tick
    //    spelduur += 1
    //    score = (spelduur * 2)
    //    lblScore.Text = score.ToString()
    //End Sub


    //Private Sub pnlSpeelveld_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlSpeelveld.Paint
    //    ' BOL :
    //    Dim rnd As New Random
    //    Dim r, b, y, xCOGCompensated As Integer

    //    r = rnd.Next(0, 255)
    //    b = rnd.Next(0, 255)
    //    y = rnd.Next(0, 255)
    //    g = e.Graphics
    //    xCOGCompensated = xPosBol + CInt(speelveldBreedte / 2)

    //    Dim rndpen As New SolidBrush(Color.FromArgb(r, b, y))

    //    ' bol wordt getekend op 90% van speeldveldHoogte, getrunceerd
    //    yIndexBol = CInt(pixelArraySize * 0.9)
    //    g.FillEllipse(rndpen, xCOGCompensated, yIndexBol * lineFragmentLength, 15, 15)


    //    ' SPEELVELD :
    //    Dim rndbic As New Pen(Color.FromArgb(r, b, y), 20)

    //    For i = 0 To pixelArraySize - 1
    //        'g.DrawLine(rndbic, pixels(i), i * lineFragmentLength, pixels(i), (i + 1) * lineFragmentLength)
    //        'g.DrawLine(rndbic, pixels(i) + straatBreedte, i * lineFragmentLength, pixels(i) + straatBreedte, i * lineFragmentLength + lineFragmentLength)
    //        g.DrawLine(New Pen(Color.White), pixels(i), i * lineFragmentLength, pixels(i), (i + 1) * lineFragmentLength)
    //        g.DrawLine(New Pen(Color.White), pixels(i) + straatBreedte, i * lineFragmentLength, pixels(i) + straatBreedte, i * lineFragmentLength + lineFragmentLength)
    //    Next
    //End Sub

    //Sub UpdatePixels()
    //    Dim nieuwe, vorige As Integer
    //    Dim rnd As New Random

    //    Dim richtingteller As Integer = 0
    //    Dim doelbereikt As Boolean = True
    //    Dim richting As Integer = 0
    //    Dim afstand As Integer = 0
    //    Dim teller As Integer = 0

    //    'Debug.WriteLine("Tick: UpdatePixels")
    //    If doelbereikt Then

    //        ' dient om richting -1 of 1 te maken
    //        richting = rnd.Next(-1, 1)
    //        If richting = 0 Then richting = 1

    //        afstand = rnd.Next(1, 150)
    //        doelbereikt = False

    //        'Debug.WriteLine("Nieuw doel: richting: " & richting & " - afstand: " & afstand)
    //        'straatBreedte -= 10
    //    End If

    //    vorige = pixels(0)

    //    If Not doelbereikt Then
    //        'Debug.WriteLine("not doelbereikt: " & afstand)
    //        If vorige <= 5 Or vorige + straatBreedte > pnlSpeelveld.Width Then
    //            Debug.WriteLine("Verander van richting " & nieuwe)
    //            richting *= -1
    //        End If

    //        nieuwe = vorige + richting * rnd.Next(0, 10)

    //        afstand -= 1
    //        If afstand = 0 Then
    //            doelbereikt = True
    //        End If
    //    End If



    //    pixels.RemoveAt(pixels.Count - 1)
    //    pixels.Insert(0, nieuwe)
    //End Sub

    //Sub DetectCollisions()
    //    ' If xPosBol > pixels(yIndexBol) And xPosBol < pixels(yIndexBol) + straatBreedte Then
    //    Dim xPosBolComp As Integer

    //    xPosBolComp = xPosBol + CInt(speelveldBreedte / 2)
    //    Debug.WriteLine("xPosBol Comp: " & xPosBolComp & " - pixels(yIndexBol): " & pixels(yIndexBol))
    //    If xPosBolComp > pixels(yIndexBol) And xPosBolComp < pixels(yIndexBol) + straatBreedte Then
    //        ' continue game
    //        'Debug.WriteLine("no collision")
    //    Else
    //        ' collision
    //        levens -= 1
    //        lblLeven.Text = levens.ToString & " %"
    //        'If levens = 0 Then
    //        '    Me.Close()
    //        'End If
    //    End If
    //End Sub

    //Private Sub lblScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblScore.Click
    //    If lblScore.Text Mod 1000 = 0 Then
    //        straatBreedte = straatBreedte * 0.9
    //    End If
    //End Sub

    //' event treedt alleen op als er een extensie (nunchuk/balanace board/...) wordt in- of uitgeschakeld
    //Private Sub wm_WiimoteExtensionChanged(ByVal sender As Object, ByVal args As WiimoteExtensionChangedEventArgs)
    //    
    //End Sub

    //Private Sub wm_OnWiimoteChanged(ByVal sender As Object, ByVal args As WiimoteChangedEventArgs)
    //    
    //End Sub

    //'Private Sub pnlSpeelveld_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlSpeelveld.MouseMove

    //'    xPosBol = MousePosition.X - 400

    //'End Sub

    //Private Sub Game_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    //    MainForm.Show()
    //End Sub

    }
}
