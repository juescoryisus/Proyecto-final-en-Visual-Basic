<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tienda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtcash = New System.Windows.Forms.TextBox()
        Me.lblreturn = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbltotaltoplay = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvlist = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbproduct = New System.Windows.Forms.ComboBox()
        Me.txtclient = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblproduct = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnagregar)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.lblreturn)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lbltotaltoplay)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dgvlist)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1241, 570)
        Me.Panel1.TabIndex = 3
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(646, 93)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(145, 44)
        Me.btnagregar.TabIndex = 22
        Me.btnagregar.Text = "Mostrar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(646, 156)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(145, 39)
        Me.btncerrar.TabIndex = 21
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(646, 34)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(145, 46)
        Me.btnadd.TabIndex = 19
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtcash
        '
        Me.txtcash.Location = New System.Drawing.Point(17, 25)
        Me.txtcash.Multiline = True
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(175, 42)
        Me.txtcash.TabIndex = 18
        '
        'lblreturn
        '
        Me.lblreturn.AutoSize = True
        Me.lblreturn.Location = New System.Drawing.Point(1091, 528)
        Me.lblreturn.Name = "lblreturn"
        Me.lblreturn.Size = New System.Drawing.Size(0, 20)
        Me.lblreturn.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1054, 494)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 22)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Return"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(617, 494)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 22)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Cash"
        '
        'lbltotaltoplay
        '
        Me.lbltotaltoplay.AutoSize = True
        Me.lbltotaltoplay.Location = New System.Drawing.Point(192, 537)
        Me.lbltotaltoplay.Name = "lbltotaltoplay"
        Me.lbltotaltoplay.Size = New System.Drawing.Size(0, 20)
        Me.lbltotaltoplay.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(130, 494)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 22)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total to pay"
        '
        'dgvlist
        '
        Me.dgvlist.AllowUserToAddRows = False
        Me.dgvlist.AllowUserToDeleteRows = False
        Me.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvlist.Enabled = False
        Me.dgvlist.Location = New System.Drawing.Point(0, 294)
        Me.dgvlist.Name = "dgvlist"
        Me.dgvlist.ReadOnly = True
        Me.dgvlist.RowHeadersVisible = False
        Me.dgvlist.RowHeadersWidth = 62
        Me.dgvlist.RowTemplate.Height = 28
        Me.dgvlist.Size = New System.Drawing.Size(1235, 197)
        Me.dgvlist.StandardTab = True
        Me.dgvlist.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "CUSTOMER"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "CODE"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRODUCT"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "PRICE"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "AMOUNT"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "TOTAL"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbproduct)
        Me.GroupBox1.Controls.Add(Me.txtclient)
        Me.GroupBox1.Controls.Add(Me.lblname)
        Me.GroupBox1.Controls.Add(Me.lblcode)
        Me.GroupBox1.Controls.Add(Me.lblprice)
        Me.GroupBox1.Controls.Add(Me.lblproduct)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 245)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Amount:"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(131, 213)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(182, 26)
        Me.txtamount.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product:"
        '
        'cmbproduct
        '
        Me.cmbproduct.AutoCompleteCustomSource.AddRange(New String() {"Pollo ", "Camisa", "Gorra"})
        Me.cmbproduct.FormattingEnabled = True
        Me.cmbproduct.Items.AddRange(New Object() {"Polo", "Gorra", "Camisa"})
        Me.cmbproduct.Location = New System.Drawing.Point(131, 80)
        Me.cmbproduct.Name = "cmbproduct"
        Me.cmbproduct.Size = New System.Drawing.Size(252, 28)
        Me.cmbproduct.TabIndex = 10
        '
        'txtclient
        '
        Me.txtclient.Location = New System.Drawing.Point(106, 36)
        Me.txtclient.Name = "txtclient"
        Me.txtclient.Size = New System.Drawing.Size(360, 26)
        Me.txtclient.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(13, 36)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(65, 22)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name:"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(105, 118)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 20)
        Me.lblcode.TabIndex = 7
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(127, 188)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(0, 20)
        Me.lblprice.TabIndex = 9
        '
        'lblproduct
        '
        Me.lblproduct.AutoSize = True
        Me.lblproduct.Location = New System.Drawing.Point(189, 153)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(0, 20)
        Me.lblproduct.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(121, 489)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 78)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(1001, 497)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtcash)
        Me.GroupBox4.Location = New System.Drawing.Point(540, 493)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(213, 74)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        '
        'Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 595)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tienda"
        Me.Text = "Tienda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnadd As Button
    Friend WithEvents txtcash As TextBox
    Friend WithEvents lblreturn As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbltotaltoplay As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvlist As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents txtamount As TextBox
    Friend WithEvents cmbproduct As ComboBox
    Friend WithEvents lblprice As Label
    Friend WithEvents lblproduct As Label
    Friend WithEvents lblcode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtclient As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
