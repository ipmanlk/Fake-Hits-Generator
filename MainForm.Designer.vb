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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.main_control_grp = New System.Windows.Forms.GroupBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.proxy_grp = New System.Windows.Forms.GroupBox()
		Me.proxy_box = New System.Windows.Forms.TextBox()
		Me.proxy_help = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.main_control_grp.SuspendLayout
		Me.proxy_grp.SuspendLayout
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.SuspendLayout
		'
		'main_control_grp
		'
		Me.main_control_grp.Controls.Add(Me.button3)
		Me.main_control_grp.Controls.Add(Me.button2)
		Me.main_control_grp.Controls.Add(Me.button1)
		Me.main_control_grp.Controls.Add(Me.textBox1)
		Me.main_control_grp.Controls.Add(Me.label1)
		Me.main_control_grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.main_control_grp.Location = New System.Drawing.Point(12, 12)
		Me.main_control_grp.Name = "main_control_grp"
		Me.main_control_grp.Size = New System.Drawing.Size(445, 123)
		Me.main_control_grp.TabIndex = 0
		Me.main_control_grp.TabStop = false
		Me.main_control_grp.Text = "Main Controls"
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(53, 36)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(380, 26)
		Me.textBox1.TabIndex = 0
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
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(53, 80)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(104, 23)
		Me.button1.TabIndex = 2
		Me.button1.Text = "Load Website"
		Me.button1.UseVisualStyleBackColor = true
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.ForeColor = System.Drawing.Color.Blue
		Me.button2.Location = New System.Drawing.Point(275, 80)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 3
		Me.button2.Text = "Start"
		Me.button2.UseVisualStyleBackColor = true
		'
		'button3
		'
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.ForeColor = System.Drawing.Color.Red
		Me.button3.Location = New System.Drawing.Point(358, 80)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(75, 23)
		Me.button3.TabIndex = 4
		Me.button3.Text = "Stop"
		Me.button3.UseVisualStyleBackColor = true
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
		'proxy_box
		'
		Me.proxy_box.Location = New System.Drawing.Point(12, 32)
		Me.proxy_box.Name = "proxy_box"
		Me.proxy_box.Size = New System.Drawing.Size(245, 20)
		Me.proxy_box.TabIndex = 0
		Me.proxy_box.Text = "121.183.4.54:51325 "
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
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.textBox2)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.Location = New System.Drawing.Point(290, 145)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(167, 84)
		Me.groupBox1.TabIndex = 2
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Hit Speed"
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(9, 32)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(148, 20)
		Me.textBox2.TabIndex = 0
		Me.textBox2.Text = "10"
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.Color.Transparent
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(6, 58)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(158, 23)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Fast Speed < Slow Speed (Val)"
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.webBrowser1)
		Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox2.Location = New System.Drawing.Point(12, 237)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(445, 123)
		Me.groupBox2.TabIndex = 5
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Web Browser"
		'
		'webBrowser1
		'
		Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.webBrowser1.Location = New System.Drawing.Point(3, 16)
		Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.webBrowser1.Name = "webBrowser1"
		Me.webBrowser1.Size = New System.Drawing.Size(439, 104)
		Me.webBrowser1.TabIndex = 0
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(469, 374)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.proxy_grp)
		Me.Controls.Add(Me.main_control_grp)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Fake Hits Generator"
		Me.main_control_grp.ResumeLayout(false)
		Me.main_control_grp.PerformLayout
		Me.proxy_grp.ResumeLayout(false)
		Me.proxy_grp.PerformLayout
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private webBrowser1 As System.Windows.Forms.WebBrowser
	Private textBox2 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private proxy_help As System.Windows.Forms.Label
	Private proxy_box As System.Windows.Forms.TextBox
	Private proxy_grp As System.Windows.Forms.GroupBox
	Private label1 As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private main_control_grp As System.Windows.Forms.GroupBox
End Class
