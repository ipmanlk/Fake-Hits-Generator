'
' Created by SharpDevelop.
' User: IP-Man
' Date: 10/14/2016
' Time: 8:21 PM
' 
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.main_control_grp = New System.Windows.Forms.GroupBox()
		Me.stop_btn = New System.Windows.Forms.Button()
		Me.start_btn = New System.Windows.Forms.Button()
		Me.load_site_btn = New System.Windows.Forms.Button()
		Me.url_box = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.hitspeed_grp = New System.Windows.Forms.GroupBox()
		Me.hit_speed_help = New System.Windows.Forms.Label()
		Me.hit_speed_val_box = New System.Windows.Forms.TextBox()
		Me.web_browser_grp = New System.Windows.Forms.GroupBox()
		Me.webBrowser = New System.Windows.Forms.WebBrowser()
		Me.hit_timer = New System.Windows.Forms.Timer(Me.components)
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.hit_count = New System.Windows.Forms.ToolStripStatusLabel()
		Me.hit_cntdown = New System.Windows.Forms.ToolStripStatusLabel()
		Me.proxy_list_grp = New System.Windows.Forms.GroupBox()
		Me.load_proxylist = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.switch_hits_txt = New System.Windows.Forms.TextBox()
		Me.autoSwitch = New System.Windows.Forms.CheckBox()
		Me.ProxyListUse = New System.Windows.Forms.CheckBox()
		Me.proxy_list = New System.Windows.Forms.ListBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.main_control_grp.SuspendLayout
		Me.hitspeed_grp.SuspendLayout
		Me.web_browser_grp.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.proxy_list_grp.SuspendLayout
		Me.SuspendLayout
		'
		'main_control_grp
		'
		Me.main_control_grp.Controls.Add(Me.stop_btn)
		Me.main_control_grp.Controls.Add(Me.start_btn)
		Me.main_control_grp.Controls.Add(Me.load_site_btn)
		Me.main_control_grp.Controls.Add(Me.url_box)
		Me.main_control_grp.Controls.Add(Me.label1)
		Me.main_control_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.main_control_grp.Location = New System.Drawing.Point(12, 12)
		Me.main_control_grp.Name = "main_control_grp"
		Me.main_control_grp.Size = New System.Drawing.Size(382, 123)
		Me.main_control_grp.TabIndex = 0
		Me.main_control_grp.TabStop = false
		Me.main_control_grp.Text = "Main Controls"
		'
		'stop_btn
		'
		Me.stop_btn.Enabled = false
		Me.stop_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.stop_btn.ForeColor = System.Drawing.Color.Red
		Me.stop_btn.Location = New System.Drawing.Point(285, 80)
		Me.stop_btn.Name = "stop_btn"
		Me.stop_btn.Size = New System.Drawing.Size(75, 23)
		Me.stop_btn.TabIndex = 4
		Me.stop_btn.Text = "Stop"
		Me.stop_btn.UseVisualStyleBackColor = true
		AddHandler Me.stop_btn.Click, AddressOf Me.Stop_btnClick
		'
		'start_btn
		'
		Me.start_btn.Enabled = false
		Me.start_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.start_btn.ForeColor = System.Drawing.Color.Blue
		Me.start_btn.Location = New System.Drawing.Point(206, 80)
		Me.start_btn.Name = "start_btn"
		Me.start_btn.Size = New System.Drawing.Size(75, 23)
		Me.start_btn.TabIndex = 3
		Me.start_btn.Text = "Start"
		Me.start_btn.UseVisualStyleBackColor = true
		AddHandler Me.start_btn.Click, AddressOf Me.Start_btnClick
		'
		'load_site_btn
		'
		Me.load_site_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.load_site_btn.Location = New System.Drawing.Point(53, 80)
		Me.load_site_btn.Name = "load_site_btn"
		Me.load_site_btn.Size = New System.Drawing.Size(104, 23)
		Me.load_site_btn.TabIndex = 2
		Me.load_site_btn.Text = "Load Website"
		Me.load_site_btn.UseVisualStyleBackColor = true
		AddHandler Me.load_site_btn.Click, AddressOf Me.Load_site_btnClick
		'
		'url_box
		'
		Me.url_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.url_box.Location = New System.Drawing.Point(53, 36)
		Me.url_box.Name = "url_box"
		Me.url_box.Size = New System.Drawing.Size(307, 26)
		Me.url_box.TabIndex = 0
		AddHandler Me.url_box.TextChanged, AddressOf Me.Url_boxTextChanged
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(11, 41)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(47, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "URL : "
		'
		'hitspeed_grp
		'
		Me.hitspeed_grp.Controls.Add(Me.hit_speed_help)
		Me.hitspeed_grp.Controls.Add(Me.hit_speed_val_box)
		Me.hitspeed_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.hitspeed_grp.Location = New System.Drawing.Point(12, 145)
		Me.hitspeed_grp.Name = "hitspeed_grp"
		Me.hitspeed_grp.Size = New System.Drawing.Size(382, 84)
		Me.hitspeed_grp.TabIndex = 2
		Me.hitspeed_grp.TabStop = false
		Me.hitspeed_grp.Text = "Hit Speed"
		'
		'hit_speed_help
		'
		Me.hit_speed_help.BackColor = System.Drawing.Color.Transparent
		Me.hit_speed_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.hit_speed_help.Location = New System.Drawing.Point(16, 58)
		Me.hit_speed_help.Name = "hit_speed_help"
		Me.hit_speed_help.Size = New System.Drawing.Size(158, 23)
		Me.hit_speed_help.TabIndex = 2
		Me.hit_speed_help.Text = "Fast Speed < Slow Speed (Val)"
		'
		'hit_speed_val_box
		'
		Me.hit_speed_val_box.Location = New System.Drawing.Point(21, 32)
		Me.hit_speed_val_box.Name = "hit_speed_val_box"
		Me.hit_speed_val_box.Size = New System.Drawing.Size(118, 20)
		Me.hit_speed_val_box.TabIndex = 0
		Me.hit_speed_val_box.Text = "10"
		'
		'web_browser_grp
		'
		Me.web_browser_grp.Controls.Add(Me.webBrowser)
		Me.web_browser_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.web_browser_grp.Location = New System.Drawing.Point(12, 237)
		Me.web_browser_grp.Name = "web_browser_grp"
		Me.web_browser_grp.Size = New System.Drawing.Size(382, 123)
		Me.web_browser_grp.TabIndex = 5
		Me.web_browser_grp.TabStop = false
		Me.web_browser_grp.Text = "Web Browser"
		'
		'webBrowser
		'
		Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill
		Me.webBrowser.Location = New System.Drawing.Point(3, 16)
		Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
		Me.webBrowser.Name = "webBrowser"
		Me.webBrowser.ScriptErrorsSuppressed = true
		Me.webBrowser.Size = New System.Drawing.Size(376, 104)
		Me.webBrowser.TabIndex = 0
		'
		'hit_timer
		'
		AddHandler Me.hit_timer.Tick, AddressOf Me.Hit_timerTick
		'
		'statusStrip1
		'
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hit_count, Me.hit_cntdown})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 371)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(581, 22)
		Me.statusStrip1.TabIndex = 6
		Me.statusStrip1.Text = "statusStrip1"
		'
		'hit_count
		'
		Me.hit_count.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.hit_count.ForeColor = System.Drawing.Color.Purple
		Me.hit_count.Name = "hit_count"
		Me.hit_count.Size = New System.Drawing.Size(0, 17)
		'
		'hit_cntdown
		'
		Me.hit_cntdown.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.hit_cntdown.Name = "hit_cntdown"
		Me.hit_cntdown.Size = New System.Drawing.Size(0, 17)
		'
		'proxy_list_grp
		'
		Me.proxy_list_grp.Controls.Add(Me.load_proxylist)
		Me.proxy_list_grp.Controls.Add(Me.label3)
		Me.proxy_list_grp.Controls.Add(Me.switch_hits_txt)
		Me.proxy_list_grp.Controls.Add(Me.autoSwitch)
		Me.proxy_list_grp.Controls.Add(Me.ProxyListUse)
		Me.proxy_list_grp.Controls.Add(Me.proxy_list)
		Me.proxy_list_grp.Controls.Add(Me.label2)
		Me.proxy_list_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.proxy_list_grp.Location = New System.Drawing.Point(407, 12)
		Me.proxy_list_grp.Name = "proxy_list_grp"
		Me.proxy_list_grp.Size = New System.Drawing.Size(160, 345)
		Me.proxy_list_grp.TabIndex = 6
		Me.proxy_list_grp.TabStop = false
		Me.proxy_list_grp.Text = "Proxy List"
		'
		'load_proxylist
		'
		Me.load_proxylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.load_proxylist.Location = New System.Drawing.Point(5, 102)
		Me.load_proxylist.Name = "load_proxylist"
		Me.load_proxylist.Size = New System.Drawing.Size(151, 23)
		Me.load_proxylist.TabIndex = 5
		Me.load_proxylist.Text = "Load Proxy List"
		Me.load_proxylist.UseVisualStyleBackColor = true
		AddHandler Me.load_proxylist.Click, AddressOf Me.Load_proxylistClick
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(127, 74)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(30, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Hits."
		'
		'switch_hits_txt
		'
		Me.switch_hits_txt.Location = New System.Drawing.Point(77, 70)
		Me.switch_hits_txt.Name = "switch_hits_txt"
		Me.switch_hits_txt.Size = New System.Drawing.Size(48, 20)
		Me.switch_hits_txt.TabIndex = 3
		Me.switch_hits_txt.Text = "10"
		AddHandler Me.switch_hits_txt.TextChanged, AddressOf Me.Switch_hits_txtTextChanged
		'
		'autoSwitch
		'
		Me.autoSwitch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.autoSwitch.Location = New System.Drawing.Point(6, 44)
		Me.autoSwitch.Name = "autoSwitch"
		Me.autoSwitch.Size = New System.Drawing.Size(132, 24)
		Me.autoSwitch.TabIndex = 2
		Me.autoSwitch.Text = "Auto Switch Proxies"
		Me.autoSwitch.UseVisualStyleBackColor = true
		'
		'ProxyListUse
		'
		Me.ProxyListUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ProxyListUse.Location = New System.Drawing.Point(6, 20)
		Me.ProxyListUse.Name = "ProxyListUse"
		Me.ProxyListUse.Size = New System.Drawing.Size(104, 24)
		Me.ProxyListUse.TabIndex = 1
		Me.ProxyListUse.Text = "Use Proxy List"
		Me.ProxyListUse.UseVisualStyleBackColor = true
		'
		'proxy_list
		'
		Me.proxy_list.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.proxy_list.FormattingEnabled = true
		Me.proxy_list.Location = New System.Drawing.Point(3, 130)
		Me.proxy_list.Name = "proxy_list"
		Me.proxy_list.Size = New System.Drawing.Size(154, 212)
		Me.proxy_list.TabIndex = 0
		AddHandler Me.proxy_list.SelectedIndexChanged, AddressOf Me.Proxy_listSelectedIndexChanged
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(3, 73)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(78, 23)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Switch After : "
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(581, 393)
		Me.Controls.Add(Me.proxy_list_grp)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.web_browser_grp)
		Me.Controls.Add(Me.hitspeed_grp)
		Me.Controls.Add(Me.main_control_grp)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Fake Hits Generator 0.4 Classic"
		Me.main_control_grp.ResumeLayout(false)
		Me.main_control_grp.PerformLayout
		Me.hitspeed_grp.ResumeLayout(false)
		Me.hitspeed_grp.PerformLayout
		Me.web_browser_grp.ResumeLayout(false)
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.proxy_list_grp.ResumeLayout(false)
		Me.proxy_list_grp.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label2 As System.Windows.Forms.Label
	Private ProxyListUse As System.Windows.Forms.CheckBox
	Private autoSwitch As System.Windows.Forms.CheckBox
	Private switch_hits_txt As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private load_proxylist As System.Windows.Forms.Button
	Private proxy_list As System.Windows.Forms.ListBox
	Private proxy_list_grp As System.Windows.Forms.GroupBox
	Private hit_cntdown As System.Windows.Forms.ToolStripStatusLabel
	Private hit_count As System.Windows.Forms.ToolStripStatusLabel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private hit_timer As System.Windows.Forms.Timer
	Private web_browser_grp As System.Windows.Forms.GroupBox
	Friend webBrowser As System.Windows.Forms.WebBrowser
	Private hit_speed_val_box As System.Windows.Forms.TextBox
	Private hit_speed_help As System.Windows.Forms.Label
	Private hitspeed_grp As System.Windows.Forms.GroupBox
	Private label1 As System.Windows.Forms.Label
	Private url_box As System.Windows.Forms.TextBox
	Private load_site_btn As System.Windows.Forms.Button
	Private start_btn As System.Windows.Forms.Button
	Private stop_btn As System.Windows.Forms.Button
	Private main_control_grp As System.Windows.Forms.GroupBox
	

	


End Class
