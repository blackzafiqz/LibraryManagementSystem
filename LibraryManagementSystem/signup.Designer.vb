<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.USERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New LibraryManagementSystem.databaseDataSet()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.USERTableAdapter = New LibraryManagementSystem.databaseDataSetTableAdapters.USERTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.databaseDataSetTableAdapters.TableAdapterManager()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(206, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(216, 20)
        Me.txtName.TabIndex = 5
        '
        'txtStudentId
        '
        Me.txtStudentId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USERBindingSource, "id", True))
        Me.txtStudentId.Location = New System.Drawing.Point(206, 114)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(216, 20)
        Me.txtStudentId.TabIndex = 6
        '
        'USERBindingSource
        '
        Me.USERBindingSource.DataMember = "USER"
        Me.USERBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(206, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(216, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(206, 165)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(216, 20)
        Me.txtPassword.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(246, 205)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(141, 205)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'USERTableAdapter
        '
        Me.USERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUTHORTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Nothing
        Me.TableAdapterManager.BORROWTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LibraryManagementSystem.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Me.USERTableAdapter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(347, 205)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 296)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "signup"
        Me.Text = "Sign Up"
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents DatabaseDataSet As databaseDataSet
    Friend WithEvents USERBindingSource As BindingSource
    Friend WithEvents USERTableAdapter As databaseDataSetTableAdapters.USERTableAdapter
    Friend WithEvents TableAdapterManager As databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnClear As Button
End Class
