<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PNGList = New System.Windows.Forms.ListView()
        Me.OptimizeButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.PNGChooser = New System.Windows.Forms.OpenFileDialog()
        Me.FileNameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OptiWorker = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'PNGList
        '
        Me.PNGList.AllowDrop = True
        Me.PNGList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PNGList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileNameColumn, Me.StatusColumn})
        Me.PNGList.GridLines = True
        Me.PNGList.Location = New System.Drawing.Point(0, 0)
        Me.PNGList.Name = "PNGList"
        Me.PNGList.Size = New System.Drawing.Size(774, 453)
        Me.PNGList.TabIndex = 0
        Me.PNGList.UseCompatibleStateImageBehavior = False
        Me.PNGList.View = System.Windows.Forms.View.Details
        '
        'OptimizeButton
        '
        Me.OptimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptimizeButton.BackColor = System.Drawing.Color.ForestGreen
        Me.OptimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.OptimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptimizeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptimizeButton.ForeColor = System.Drawing.SystemColors.Control
        Me.OptimizeButton.Location = New System.Drawing.Point(239, 459)
        Me.OptimizeButton.Name = "OptimizeButton"
        Me.OptimizeButton.Size = New System.Drawing.Size(523, 58)
        Me.OptimizeButton.TabIndex = 1
        Me.OptimizeButton.Text = "Optimize PNGs"
        Me.OptimizeButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(12, 459)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(221, 58)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add Files"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'PNGChooser
        '
        Me.PNGChooser.DefaultExt = "png"
        Me.PNGChooser.Filter = "PNG Images|*.png"
        Me.PNGChooser.Multiselect = True
        Me.PNGChooser.Title = "Choose PNGs"
        '
        'FileNameColumn
        '
        Me.FileNameColumn.Tag = ""
        Me.FileNameColumn.Text = "File Name"
        Me.FileNameColumn.Width = 620
        '
        'StatusColumn
        '
        Me.StatusColumn.Text = "Status"
        Me.StatusColumn.Width = 110
        '
        'OptiWorker
        '
        Me.OptiWorker.WorkerSupportsCancellation = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.OptimizeButton)
        Me.Controls.Add(Me.PNGList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PNGPro 2019-03-23"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNGList As ListView
    Friend WithEvents OptimizeButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents PNGChooser As OpenFileDialog
    Friend WithEvents FileNameColumn As ColumnHeader
    Friend WithEvents StatusColumn As ColumnHeader
    Friend WithEvents OptiWorker As System.ComponentModel.BackgroundWorker
End Class
