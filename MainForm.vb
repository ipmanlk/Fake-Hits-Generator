'
' Created by SharpDevelop.
' User: IP-Man
' Date: 10/14/2016
' Time: 8:21 PM
' 
Public Partial Class MainForm
	Dim Timer_Value As Integer 
	Dim Speed As Integer 
	Dim Hits As Integer 
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Load_site_btnClick(sender As Object, e As EventArgs)	
		
		proxy_box.Text = proxy_box.Text.Trim
		url_box.Text = url_box.Text.Trim
		hit_speed_val_box.Text = hit_speed_val_box.Text.Trim 
		
		If String.IsNullOrEmpty(url_box.Text) Or String.IsNullOrEmpty(hit_speed_val_box.Text) Then 
			MsgBox("Input details are missing!",vbExclamation,"Error")
			
		Else
			If proxy_box.Text = "null" Then		
				webBrowser.Navigate(url_box.Text)
			Else 
				Use_Proxy.UseProxy(proxy_box.Text) 
				webBrowser.Navigate(url_box.Text)
			End If
			
			start_btn.Enabled = True
			load_site_btn.Enabled = False	
			
		End If
	End Sub
	
	Sub Start_btnClick(sender As Object, e As EventArgs)
		hit_timer.Enabled = True
		Speed = hit_speed_val_box.Text
		Hits = 0
		start_btn.Enabled = False 
		stop_btn.Enabled = True 
	End Sub
	
	Sub Hit_timerTick(sender As Object, e As EventArgs)		
		Timer_Value += 1
		hit_cntdown.Text = "Waiting : " & Timer_Value.ToString
		
		If Timer_Value = Speed Then 			
			webBrowser.Refresh
			webBrowser.Navigate(url_box.Text)
			hit_count.Text = "Hits : " & Hits.ToString 
			Timer_Value = 0
			Hits += 1
		End If	
	End Sub
	
	Sub Stop_btnClick(sender As Object, e As EventArgs)
		hit_timer.Enabled = False 
		stop_btn.Enabled = False
		load_site_btn.Enabled = True
		hit_cntdown.Text = "Waiting : Stopped"
	End Sub
	
	Sub Url_boxTextChanged(sender As Object, e As EventArgs)
		load_site_btn.Enabled = True
		start_btn.Enabled = False 
		stop_btn.Enabled = False 
	End Sub
End Class
