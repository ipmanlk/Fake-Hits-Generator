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
		Me.proxy_grp = New System.Windows.Forms.GroupBox()
		Me.proxy_help = New System.Windows.Forms.Label()
		Me.proxy_box = New System.Windows.Forms.TextBox()
		Me.hitspeed_grp = New System.Windows.Forms.GroupBox()
		Me.hit_speed_help = New System.Windows.Forms.Label()
		Me.hit_speed_val_box = New System.Windows.Forms.TextBox()
		Me.web_browser_grp = New System.Windows.Forms.GroupBox()
		Me.webBrowser = New System.Windows.Forms.WebBrowser()
		Me.hit_timer = New System.Windows.Forms.Timer(Me.components)
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.hit_count = New System.Windows.Forms.ToolStripStatusLabel()
		Me.hit_cntdown = New System.Windows.Forms.ToolStripStatusLabel()
		Me.main_control_grp.SuspendLayout
		Me.proxy_grp.SuspendLayout
		Me.hitspeed_grp.SuspendLayout
		Me.web_browser_grp.SuspendLayout
		Me.statusStrip1.SuspendLayout
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
		Me.main_control_grp.Size = New System.Drawing.Size(445, 123)
		Me.main_control_grp.TabIndex = 0
		Me.main_control_grp.TabStop = false
		Me.main_control_grp.Text = "Main Controls"
		'
		'stop_btn
		'
		Me.stop_btn.Enabled = false
		Me.stop_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.stop_btn.ForeColor = System.Drawing.Color.Red
		Me.stop_btn.Location = New System.Drawing.Point(358, 80)
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
		Me.start_btn.Location = New System.Drawing.Point(275, 80)
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
		Me.url_box.Size = New System.Drawing.Size(380, 26)
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
		'proxy_grp
		'
		Me.proxy_grp.Controls.Add(Me.proxy_help)
		Me.proxy_grp.Controls.Add(Me.proxy_box)
		Me.proxy_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.proxy_grp.Location = New System.Drawing.Point(12, 145)
		Me.proxy_grp.Name = "proxy_grp"
		Me.proxy_grp.Size = New System.Drawing.Size(269, 84)
		Me.proxy_grp.TabIndex = 1
		Me.proxy_grp.TabStop = false
		Me.proxy_grp.Text = "Proxy Setup"
		'
		'proxy_help
		'
		Me.proxy_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.proxy_help.Location = New System.Drawing.Point(9, 57)
		Me.proxy_help.Name = "proxy_help"
		Me.proxy_help.Size = New System.Drawing.Size(98, 23)
		Me.proxy_help.TabIndex = 1
		Me.proxy_help.Text = "Format - proxy:port"
		'
		'proxy_box
		'
		Me.proxy_box.Location = New System.Drawing.Point(12, 32)
		Me.proxy_box.Name = "proxy_box"
		Me.proxy_box.Size = New System.Drawing.Size(245, 20)
		Me.proxy_box.TabIndex = 0
		Me.proxy_box.Text = "null"
		'
		'hitspeed_grp
		'
		Me.hitspeed_grp.Controls.Add(Me.hit_speed_help)
		Me.hitspeed_grp.Controls.Add(Me.hit_speed_val_box)
		Me.hitspeed_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.hitspeed_grp.Location = New System.Drawing.Point(290, 145)
		Me.hitspeed_grp.Name = "hitspeed_grp"
		Me.hitspeed_grp.Size = New System.Drawing.Size(167, 84)
		Me.hitspeed_grp.TabIndex = 2
		Me.hitspeed_grp.TabStop = false
		Me.hitspeed_grp.Text = "Hit Speed"
		'
		'hit_speed_help
		'
		Me.hit_speed_help.BackColor = System.Drawing.Color.Transparent
		Me.hit_speed_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.hit_speed_help.Location = New System.Drawing.Point(6, 58)
		Me.hit_speed_help.Name = "hit_speed_help"
		Me.hit_speed_help.Size = New System.Drawing.Size(158, 23)
		Me.hit_speed_help.TabIndex = 2
		Me.hit_speed_help.Text = "Fast Speed < Slow Speed (Val)"
		'
		'hit_speed_val_box
		'
		Me.hit_speed_val_box.Location = New System.Drawing.Point(9, 32)
		Me.hit_speed_val_box.Name = "hit_speed_val_box"
		Me.hit_speed_val_box.Size = New System.Drawing.Size(148, 20)
		Me.hit_speed_val_box.TabIndex = 0
		Me.hit_speed_val_box.Text = "10"
		'
		'web_browser_grp
		'
		Me.web_browser_grp.Controls.Add(Me.webBrowser)
		Me.web_browser_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.web_browser_grp.Location = New System.Drawing.Point(12, 237)
		Me.web_browser_grp.Name = "web_browser_grp"
		Me.web_browser_grp.Size = New System.Drawing.Size(445, 123)
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
		Me.webBrowser.Size = New System.Drawing.Size(439, 104)
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
		Me.statusStrip1.Size = New System.Drawing.Size(469, 22)
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
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(469, 393)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.web_browser_grp)
		Me.Controls.Add(Me.hitspeed_grp)
		Me.Controls.Add(Me.proxy_grp)
		Me.Controls.Add(Me.main_control_grp)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Fake Hits Generator 0.4 Classic"
		Me.main_control_grp.ResumeLayout(false)
		Me.main_control_grp.PerformLayout
		Me.proxy_grp.ResumeLayout(false)
		Me.proxy_grp.PerformLayout
		Me.hitspeed_grp.ResumeLayout(false)
		Me.hitspeed_grp.PerformLayout
		Me.web_browser_grp.ResumeLayout(false)
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private hit_cntdown As System.Windows.Forms.ToolStripStatusLabel
	Private hit_count As System.Windows.Forms.ToolStripStatusLabel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private hit_timer As System.Windows.Forms.Timer
	Private web_browser_grp As System.Windows.Forms.GroupBox
	Friend webBrowser As System.Windows.Forms.WebBrowser
	Private hit_speed_val_box As System.Windows.Forms.TextBox
	Private hit_speed_help As System.Windows.Forms.Label
	Private hitspeed_grp As System.Windows.Forms.GroupBox
	Private proxy_help As System.Windows.Forms.Label
	Private proxy_box As System.Windows.Forms.TextBox
	Private proxy_grp As System.Windows.Forms.GroupBox
	Private label1 As System.Windows.Forms.Label
	Private url_box As System.Windows.Forms.TextBox
	Private load_site_btn As System.Windows.Forms.Button
	Private start_btn As System.Windows.Forms.Button
	Private stop_btn As System.Windows.Forms.Button
	Private main_control_grp As System.Windows.Forms.GroupBox
End Class
