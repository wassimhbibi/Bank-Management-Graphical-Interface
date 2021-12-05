<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sdb = New System.Windows.Forms.TextBox()
        Me.n_c = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.wa1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.d_oo = New System.Windows.Forms.TextBox()
        CType(Me.wa1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Freestyle Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ajouter compte client"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Freestyle Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(214, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 33)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "modifer compte client"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Freestyle Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(110, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 33)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "suprimet compte client"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "date_d'ouverture="
        '
        'sdb
        '
        Me.sdb.Location = New System.Drawing.Point(134, 106)
        Me.sdb.Name = "sdb"
        Me.sdb.Size = New System.Drawing.Size(100, 20)
        Me.sdb.TabIndex = 13
        '
        'n_c
        '
        Me.n_c.Location = New System.Drawing.Point(134, 29)
        Me.n_c.Name = "n_c"
        Me.n_c.Size = New System.Drawing.Size(100, 20)
        Me.n_c.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "num_compte="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "solde de base="
        '
        'wa1
        '
        Me.wa1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.wa1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.wa1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.wa1.Location = New System.Drawing.Point(416, 28)
        Me.wa1.Name = "wa1"
        Me.wa1.Size = New System.Drawing.Size(343, 150)
        Me.wa1.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "num_compte"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "date_d'ouveture"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "solde de base"
        Me.Column3.Name = "Column3"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Freestyle Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 33)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "exporter "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Freestyle Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(110, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 33)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "importer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Freestyle Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(214, 58)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 33)
        Me.Button9.TabIndex = 29
        Me.Button9.Text = "vider la liste"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Freestyle Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(110, 97)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(101, 29)
        Me.Button10.TabIndex = 30
        Me.Button10.Text = "quiter"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 132)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "choix"
        '
        'd_oo
        '
        Me.d_oo.Location = New System.Drawing.Point(157, 67)
        Me.d_oo.Name = "d_oo"
        Me.d_oo.Size = New System.Drawing.Size(100, 20)
        Me.d_oo.TabIndex = 34
        '
        'compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projet_gestion_de_banque.My.Resources.Resources.téléchargement__5_
        Me.ClientSize = New System.Drawing.Size(872, 294)
        Me.Controls.Add(Me.d_oo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.wa1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.n_c)
        Me.Controls.Add(Me.sdb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "compte"
        Me.Text = "compte"
        CType(Me.wa1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sdb As System.Windows.Forms.TextBox
    Friend WithEvents n_c As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents wa1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents d_oo As System.Windows.Forms.TextBox
End Class
