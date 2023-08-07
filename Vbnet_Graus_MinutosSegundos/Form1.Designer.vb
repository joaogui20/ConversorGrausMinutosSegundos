<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversao
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
        Me.lblGraus = New System.Windows.Forms.Label()
        Me.txtGraus = New System.Windows.Forms.TextBox()
        Me.btnConverter = New System.Windows.Forms.Button()
        Me.lblConversao = New System.Windows.Forms.Label()
        Me.txtMinutosSegundos = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGraus
        '
        Me.lblGraus.AutoSize = True
        Me.lblGraus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraus.Location = New System.Drawing.Point(12, 19)
        Me.lblGraus.Name = "lblGraus"
        Me.lblGraus.Size = New System.Drawing.Size(221, 24)
        Me.lblGraus.TabIndex = 0
        Me.lblGraus.Text = "Informe o valor em Graus"
        '
        'txtGraus
        '
        Me.txtGraus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGraus.Location = New System.Drawing.Point(16, 46)
        Me.txtGraus.Name = "txtGraus"
        Me.txtGraus.Size = New System.Drawing.Size(399, 35)
        Me.txtGraus.TabIndex = 1
        '
        'btnConverter
        '
        Me.btnConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConverter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConverter.Location = New System.Drawing.Point(16, 100)
        Me.btnConverter.Name = "btnConverter"
        Me.btnConverter.Size = New System.Drawing.Size(399, 66)
        Me.btnConverter.TabIndex = 2
        Me.btnConverter.Text = "Converter"
        Me.btnConverter.UseVisualStyleBackColor = True
        '
        'lblConversao
        '
        Me.lblConversao.AutoSize = True
        Me.lblConversao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversao.Location = New System.Drawing.Point(12, 181)
        Me.lblConversao.Name = "lblConversao"
        Me.lblConversao.Size = New System.Drawing.Size(221, 24)
        Me.lblConversao.TabIndex = 3
        Me.lblConversao.Text = "Informe o valor em Graus"
        '
        'txtMinutosSegundos
        '
        Me.txtMinutosSegundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutosSegundos.Location = New System.Drawing.Point(12, 208)
        Me.txtMinutosSegundos.Name = "txtMinutosSegundos"
        Me.txtMinutosSegundos.Size = New System.Drawing.Size(399, 35)
        Me.txtMinutosSegundos.TabIndex = 4
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSair.Location = New System.Drawing.Point(12, 274)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(93, 44)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmConversao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(427, 355)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.txtMinutosSegundos)
        Me.Controls.Add(Me.lblConversao)
        Me.Controls.Add(Me.btnConverter)
        Me.Controls.Add(Me.txtGraus)
        Me.Controls.Add(Me.lblGraus)
        Me.Name = "frmConversao"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGraus As System.Windows.Forms.Label
    Friend WithEvents txtGraus As System.Windows.Forms.TextBox
    Friend WithEvents btnConverter As System.Windows.Forms.Button
    Friend WithEvents lblConversao As System.Windows.Forms.Label
    Friend WithEvents txtMinutosSegundos As System.Windows.Forms.TextBox
    Friend WithEvents btnSair As System.Windows.Forms.Button

End Class
