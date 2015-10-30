<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChooseButton = New System.Windows.Forms.Button()
        Me.SelectedLabel = New System.Windows.Forms.Label()
        Me.PDFCheckBox = New System.Windows.Forms.CheckBox()
        Me.OutputButton = New System.Windows.Forms.Button()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.InputFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.DPINumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DPILabel = New System.Windows.Forms.Label()
        Me.OutputFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ToolsFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.CompressCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.DPINumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SWFTools folder"
        '
        'ChooseButton
        '
        Me.ChooseButton.BackColor = System.Drawing.SystemColors.Control
        Me.ChooseButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.ChooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChooseButton.Location = New System.Drawing.Point(12, 9)
        Me.ChooseButton.Name = "ChooseButton"
        Me.ChooseButton.Size = New System.Drawing.Size(112, 21)
        Me.ChooseButton.TabIndex = 3
        Me.ChooseButton.Text = "Choose .swf files"
        Me.ChooseButton.UseVisualStyleBackColor = False
        '
        'SelectedLabel
        '
        Me.SelectedLabel.AutoSize = True
        Me.SelectedLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.SelectedLabel.Location = New System.Drawing.Point(130, 13)
        Me.SelectedLabel.Name = "SelectedLabel"
        Me.SelectedLabel.Size = New System.Drawing.Size(77, 13)
        Me.SelectedLabel.TabIndex = 4
        Me.SelectedLabel.Text = "0 files selected"
        '
        'PDFCheckBox
        '
        Me.PDFCheckBox.AutoSize = True
        Me.PDFCheckBox.Checked = True
        Me.PDFCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PDFCheckBox.ForeColor = System.Drawing.SystemColors.Control
        Me.PDFCheckBox.Location = New System.Drawing.Point(12, 80)
        Me.PDFCheckBox.Name = "PDFCheckBox"
        Me.PDFCheckBox.Size = New System.Drawing.Size(130, 17)
        Me.PDFCheckBox.TabIndex = 5
        Me.PDFCheckBox.Text = "Compile PNGs to PDF"
        Me.PDFCheckBox.UseVisualStyleBackColor = True
        '
        'OutputButton
        '
        Me.OutputButton.BackColor = System.Drawing.SystemColors.Control
        Me.OutputButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.OutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OutputButton.Location = New System.Drawing.Point(293, 47)
        Me.OutputButton.Name = "OutputButton"
        Me.OutputButton.Size = New System.Drawing.Size(64, 23)
        Me.OutputButton.TabIndex = 7
        Me.OutputButton.Text = "Change"
        Me.OutputButton.UseVisualStyleBackColor = False
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(12, 49)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(275, 20)
        Me.OutputTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(12, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Output Directory"
        '
        'ConvertButton
        '
        Me.ConvertButton.BackColor = System.Drawing.SystemColors.Control
        Me.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConvertButton.Location = New System.Drawing.Point(148, 76)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(209, 23)
        Me.ConvertButton.TabIndex = 9
        Me.ConvertButton.Text = "Convert!"
        Me.ConvertButton.UseVisualStyleBackColor = False
        '
        'InputFileDialog
        '
        Me.InputFileDialog.FileName = "OpenFileDialog1"
        Me.InputFileDialog.Filter = "SWF Files|*.swf"
        Me.InputFileDialog.Multiselect = True
        '
        'DPINumericUpDown
        '
        Me.DPINumericUpDown.Location = New System.Drawing.Point(292, 11)
        Me.DPINumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.DPINumericUpDown.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.DPINumericUpDown.Name = "DPINumericUpDown"
        Me.DPINumericUpDown.Size = New System.Drawing.Size(64, 20)
        Me.DPINumericUpDown.TabIndex = 10
        Me.DPINumericUpDown.Value = New Decimal(New Integer() {330, 0, 0, 0})
        '
        'DPILabel
        '
        Me.DPILabel.AutoSize = True
        Me.DPILabel.ForeColor = System.Drawing.SystemColors.Control
        Me.DPILabel.Location = New System.Drawing.Point(261, 13)
        Me.DPILabel.Name = "DPILabel"
        Me.DPILabel.Size = New System.Drawing.Size(25, 13)
        Me.DPILabel.TabIndex = 11
        Me.DPILabel.Text = "DPI"
        '
        'StatusLabel
        '
        Me.StatusLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.StatusLabel.Location = New System.Drawing.Point(148, 107)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(209, 13)
        Me.StatusLabel.TabIndex = 12
        Me.StatusLabel.Text = "READY"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CompressCheckBox
        '
        Me.CompressCheckBox.AutoSize = True
        Me.CompressCheckBox.Checked = True
        Me.CompressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CompressCheckBox.ForeColor = System.Drawing.SystemColors.Control
        Me.CompressCheckBox.Location = New System.Drawing.Point(12, 103)
        Me.CompressCheckBox.Name = "CompressCheckBox"
        Me.CompressCheckBox.Size = New System.Drawing.Size(107, 17)
        Me.CompressCheckBox.TabIndex = 13
        Me.CompressCheckBox.Text = "Compress in PDF"
        Me.CompressCheckBox.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(368, 126)
        Me.Controls.Add(Me.CompressCheckBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.DPILabel)
        Me.Controls.Add(Me.DPINumericUpDown)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OutputButton)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.PDFCheckBox)
        Me.Controls.Add(Me.SelectedLabel)
        Me.Controls.Add(Me.ChooseButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk SWF to PNG/PDF"
        CType(Me.DPINumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ChooseButton As Button
    Friend WithEvents SelectedLabel As Label
    Friend WithEvents PDFCheckBox As CheckBox
    Friend WithEvents OutputButton As Button
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ConvertButton As Button
    Friend WithEvents InputFileDialog As OpenFileDialog
    Friend WithEvents DPINumericUpDown As NumericUpDown
    Friend WithEvents OutputFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents DPILabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents ToolsFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents CompressCheckBox As CheckBox
End Class
