<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.player = New System.Windows.Forms.PictureBox()
        Me.game_clock = New System.Windows.Forms.Timer(Me.components)
        Me.top_border = New System.Windows.Forms.PictureBox()
        Me.bottom_border = New System.Windows.Forms.PictureBox()
        Me.right_border = New System.Windows.Forms.PictureBox()
        Me.left_border = New System.Windows.Forms.PictureBox()
        Me.gravity = New System.Windows.Forms.Timer(Me.components)
        Me.jump = New System.Windows.Forms.Timer(Me.components)
        Me.go_right = New System.Windows.Forms.Timer(Me.components)
        Me.go_left = New System.Windows.Forms.Timer(Me.components)
        Me.jump_height = New System.Windows.Forms.PictureBox()
        Me.green_sprite = New System.Windows.Forms.PictureBox()
        Me.yellow_sprite = New System.Windows.Forms.PictureBox()
        Me.black_sprite = New System.Windows.Forms.PictureBox()
        Me.coin = New System.Windows.Forms.PictureBox()
        Me.randomize = New System.Windows.Forms.Timer(Me.components)
        Me.random_lbl = New System.Windows.Forms.Label()
        Me.redsprite = New System.Windows.Forms.Timer(Me.components)
        Me.animation_fall = New System.Windows.Forms.Timer(Me.components)
        Me.red_sprite = New System.Windows.Forms.PictureBox()
        Me.time_frame = New System.Windows.Forms.Label()
        Me.greensprite = New System.Windows.Forms.Timer(Me.components)
        Me.blacksprite = New System.Windows.Forms.Timer(Me.components)
        Me.yellowsprite = New System.Windows.Forms.Timer(Me.components)
        Me.coin_ = New System.Windows.Forms.Timer(Me.components)
        Me.healthbar_base = New System.Windows.Forms.PictureBox()
        Me.player_healthbar = New System.Windows.Forms.PictureBox()
        Me.player_health_lbl = New System.Windows.Forms.Label()
        Me.display_damage_lbl = New System.Windows.Forms.Label()
        Me.died_animation = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.coins_counter = New System.Windows.Forms.Label()
        Me.game_Timer_lbl = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.game_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.display_menu_lbl = New System.Windows.Forms.Label()
        Me.display_menu_lbl2 = New System.Windows.Forms.Label()
        Me.display_menu_help = New System.Windows.Forms.Label()
        Me.help_menu = New System.Windows.Forms.PictureBox()
        Me.close_menu_lbl = New System.Windows.Forms.Label()
        Me.version_lbl = New System.Windows.Forms.Label()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.top_border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottom_border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.right_border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.left_border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jump_height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green_sprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yellow_sprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_sprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red_sprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.healthbar_base, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player_healthbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.help_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Green
        Me.player.Location = New System.Drawing.Point(276, 160)
        Me.player.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(40, 41)
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'game_clock
        '
        '
        'top_border
        '
        Me.top_border.Location = New System.Drawing.Point(-6, -11)
        Me.top_border.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.top_border.Name = "top_border"
        Me.top_border.Size = New System.Drawing.Size(622, 25)
        Me.top_border.TabIndex = 1
        Me.top_border.TabStop = False
        '
        'bottom_border
        '
        Me.bottom_border.Location = New System.Drawing.Point(-6, 388)
        Me.bottom_border.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bottom_border.Name = "bottom_border"
        Me.bottom_border.Size = New System.Drawing.Size(622, 86)
        Me.bottom_border.TabIndex = 2
        Me.bottom_border.TabStop = False
        '
        'right_border
        '
        Me.right_border.Location = New System.Drawing.Point(598, 10)
        Me.right_border.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.right_border.Name = "right_border"
        Me.right_border.Size = New System.Drawing.Size(28, 380)
        Me.right_border.TabIndex = 3
        Me.right_border.TabStop = False
        '
        'left_border
        '
        Me.left_border.Location = New System.Drawing.Point(-6, 10)
        Me.left_border.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.left_border.Name = "left_border"
        Me.left_border.Size = New System.Drawing.Size(20, 380)
        Me.left_border.TabIndex = 4
        Me.left_border.TabStop = False
        '
        'gravity
        '
        Me.gravity.Interval = 1
        '
        'jump
        '
        Me.jump.Interval = 1
        '
        'go_right
        '
        Me.go_right.Interval = 1
        '
        'go_left
        '
        Me.go_left.Interval = 1
        '
        'jump_height
        '
        Me.jump_height.Location = New System.Drawing.Point(-6, 76)
        Me.jump_height.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.jump_height.Name = "jump_height"
        Me.jump_height.Size = New System.Drawing.Size(622, 124)
        Me.jump_height.TabIndex = 5
        Me.jump_height.TabStop = False
        '
        'green_sprite
        '
        Me.green_sprite.BackColor = System.Drawing.Color.Green
        Me.green_sprite.Location = New System.Drawing.Point(617, 297)
        Me.green_sprite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.green_sprite.Name = "green_sprite"
        Me.green_sprite.Size = New System.Drawing.Size(20, 21)
        Me.green_sprite.TabIndex = 7
        Me.green_sprite.TabStop = False
        '
        'yellow_sprite
        '
        Me.yellow_sprite.BackColor = System.Drawing.Color.Yellow
        Me.yellow_sprite.Location = New System.Drawing.Point(616, 254)
        Me.yellow_sprite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.yellow_sprite.Name = "yellow_sprite"
        Me.yellow_sprite.Size = New System.Drawing.Size(37, 37)
        Me.yellow_sprite.TabIndex = 8
        Me.yellow_sprite.TabStop = False
        '
        'black_sprite
        '
        Me.black_sprite.BackColor = System.Drawing.Color.Black
        Me.black_sprite.Location = New System.Drawing.Point(624, 314)
        Me.black_sprite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.black_sprite.Name = "black_sprite"
        Me.black_sprite.Size = New System.Drawing.Size(37, 37)
        Me.black_sprite.TabIndex = 9
        Me.black_sprite.TabStop = False
        '
        'coin
        '
        Me.coin.BackColor = System.Drawing.Color.Gold
        Me.coin.Location = New System.Drawing.Point(610, 285)
        Me.coin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.coin.Name = "coin"
        Me.coin.Size = New System.Drawing.Size(17, 17)
        Me.coin.TabIndex = 10
        Me.coin.TabStop = False
        '
        'randomize
        '
        Me.randomize.Interval = 1000
        '
        'random_lbl
        '
        Me.random_lbl.AutoSize = True
        Me.random_lbl.Location = New System.Drawing.Point(19, 139)
        Me.random_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.random_lbl.Name = "random_lbl"
        Me.random_lbl.Size = New System.Drawing.Size(13, 13)
        Me.random_lbl.TabIndex = 11
        Me.random_lbl.Text = "0"
        '
        'redsprite
        '
        '
        'animation_fall
        '
        '
        'red_sprite
        '
        Me.red_sprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.red_sprite.Location = New System.Drawing.Point(641, 314)
        Me.red_sprite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.red_sprite.Name = "red_sprite"
        Me.red_sprite.Size = New System.Drawing.Size(64, 69)
        Me.red_sprite.TabIndex = 13
        Me.red_sprite.TabStop = False
        '
        'time_frame
        '
        Me.time_frame.AutoSize = True
        Me.time_frame.Location = New System.Drawing.Point(564, 19)
        Me.time_frame.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.time_frame.Name = "time_frame"
        Me.time_frame.Size = New System.Drawing.Size(40, 13)
        Me.time_frame.TabIndex = 12
        Me.time_frame.Text = "playing"
        '
        'greensprite
        '
        '
        'blacksprite
        '
        '
        'yellowsprite
        '
        '
        'coin_
        '
        '
        'healthbar_base
        '
        Me.healthbar_base.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.healthbar_base.Location = New System.Drawing.Point(21, 19)
        Me.healthbar_base.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.healthbar_base.Name = "healthbar_base"
        Me.healthbar_base.Size = New System.Drawing.Size(150, 20)
        Me.healthbar_base.TabIndex = 14
        Me.healthbar_base.TabStop = False
        '
        'player_healthbar
        '
        Me.player_healthbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.player_healthbar.Location = New System.Drawing.Point(21, 19)
        Me.player_healthbar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.player_healthbar.Name = "player_healthbar"
        Me.player_healthbar.Size = New System.Drawing.Size(150, 20)
        Me.player_healthbar.TabIndex = 15
        Me.player_healthbar.TabStop = False
        '
        'player_health_lbl
        '
        Me.player_health_lbl.AutoSize = True
        Me.player_health_lbl.Location = New System.Drawing.Point(27, 22)
        Me.player_health_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.player_health_lbl.Name = "player_health_lbl"
        Me.player_health_lbl.Size = New System.Drawing.Size(25, 13)
        Me.player_health_lbl.TabIndex = 16
        Me.player_health_lbl.Text = "200"
        '
        'display_damage_lbl
        '
        Me.display_damage_lbl.AutoSize = True
        Me.display_damage_lbl.Font = New System.Drawing.Font("Minerva", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_damage_lbl.Location = New System.Drawing.Point(287, 147)
        Me.display_damage_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.display_damage_lbl.Name = "display_damage_lbl"
        Me.display_damage_lbl.Size = New System.Drawing.Size(31, 34)
        Me.display_damage_lbl.TabIndex = 17
        Me.display_damage_lbl.Text = "0"
        '
        'died_animation
        '
        Me.died_animation.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(22, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 28)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'coins_counter
        '
        Me.coins_counter.AutoSize = True
        Me.coins_counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coins_counter.Location = New System.Drawing.Point(26, 48)
        Me.coins_counter.Name = "coins_counter"
        Me.coins_counter.Size = New System.Drawing.Size(18, 20)
        Me.coins_counter.TabIndex = 19
        Me.coins_counter.Text = "0"
        '
        'game_Timer_lbl
        '
        Me.game_Timer_lbl.AutoSize = True
        Me.game_Timer_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.game_Timer_lbl.Location = New System.Drawing.Point(89, 48)
        Me.game_Timer_lbl.Name = "game_Timer_lbl"
        Me.game_Timer_lbl.Size = New System.Drawing.Size(18, 20)
        Me.game_Timer_lbl.TabIndex = 23
        Me.game_Timer_lbl.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(82, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 22)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'game_Timer
        '
        Me.game_Timer.Interval = 1000
        '
        'display_menu_lbl
        '
        Me.display_menu_lbl.AutoSize = True
        Me.display_menu_lbl.Font = New System.Drawing.Font("Minerva", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_menu_lbl.Location = New System.Drawing.Point(279, 180)
        Me.display_menu_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.display_menu_lbl.Name = "display_menu_lbl"
        Me.display_menu_lbl.Size = New System.Drawing.Size(39, 20)
        Me.display_menu_lbl.TabIndex = 25
        Me.display_menu_lbl.Text = "blank"
        '
        'display_menu_lbl2
        '
        Me.display_menu_lbl2.AutoSize = True
        Me.display_menu_lbl2.Font = New System.Drawing.Font("Minerva", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_menu_lbl2.Location = New System.Drawing.Point(279, 201)
        Me.display_menu_lbl2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.display_menu_lbl2.Name = "display_menu_lbl2"
        Me.display_menu_lbl2.Size = New System.Drawing.Size(31, 20)
        Me.display_menu_lbl2.TabIndex = 26
        Me.display_menu_lbl2.Text = "Quit"
        '
        'display_menu_help
        '
        Me.display_menu_help.AutoSize = True
        Me.display_menu_help.Font = New System.Drawing.Font("Minerva", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_menu_help.Location = New System.Drawing.Point(279, 221)
        Me.display_menu_help.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.display_menu_help.Name = "display_menu_help"
        Me.display_menu_help.Size = New System.Drawing.Size(35, 20)
        Me.display_menu_help.TabIndex = 27
        Me.display_menu_help.Text = "Help"
        '
        'help_menu
        '
        Me.help_menu.BackgroundImage = CType(resources.GetObject("help_menu.BackgroundImage"), System.Drawing.Image)
        Me.help_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.help_menu.InitialImage = CType(resources.GetObject("help_menu.InitialImage"), System.Drawing.Image)
        Me.help_menu.Location = New System.Drawing.Point(126, 87)
        Me.help_menu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.help_menu.Name = "help_menu"
        Me.help_menu.Size = New System.Drawing.Size(393, 256)
        Me.help_menu.TabIndex = 28
        Me.help_menu.TabStop = False
        '
        'close_menu_lbl
        '
        Me.close_menu_lbl.AutoSize = True
        Me.close_menu_lbl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.close_menu_lbl.ForeColor = System.Drawing.Color.Teal
        Me.close_menu_lbl.Location = New System.Drawing.Point(466, 328)
        Me.close_menu_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.close_menu_lbl.Name = "close_menu_lbl"
        Me.close_menu_lbl.Size = New System.Drawing.Size(52, 13)
        Me.close_menu_lbl.TabIndex = 29
        Me.close_menu_lbl.Text = "X CLOSE"
        '
        'version_lbl
        '
        Me.version_lbl.AutoSize = True
        Me.version_lbl.Location = New System.Drawing.Point(323, 180)
        Me.version_lbl.Name = "version_lbl"
        Me.version_lbl.Size = New System.Drawing.Size(32, 13)
        Me.version_lbl.TabIndex = 30
        Me.version_lbl.Text = "V 0.1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 402)
        Me.Controls.Add(Me.close_menu_lbl)
        Me.Controls.Add(Me.help_menu)
        Me.Controls.Add(Me.version_lbl)
        Me.Controls.Add(Me.display_damage_lbl)
        Me.Controls.Add(Me.display_menu_help)
        Me.Controls.Add(Me.display_menu_lbl2)
        Me.Controls.Add(Me.display_menu_lbl)
        Me.Controls.Add(Me.game_Timer_lbl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.coins_counter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.player_health_lbl)
        Me.Controls.Add(Me.player_healthbar)
        Me.Controls.Add(Me.healthbar_base)
        Me.Controls.Add(Me.red_sprite)
        Me.Controls.Add(Me.time_frame)
        Me.Controls.Add(Me.random_lbl)
        Me.Controls.Add(Me.coin)
        Me.Controls.Add(Me.black_sprite)
        Me.Controls.Add(Me.yellow_sprite)
        Me.Controls.Add(Me.green_sprite)
        Me.Controls.Add(Me.left_border)
        Me.Controls.Add(Me.right_border)
        Me.Controls.Add(Me.bottom_border)
        Me.Controls.Add(Me.top_border)
        Me.Controls.Add(Me.jump_height)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Block Game"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.top_border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottom_border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.right_border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.left_border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jump_height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green_sprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yellow_sprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_sprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red_sprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.healthbar_base, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player_healthbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.help_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents game_clock As Timer
    Friend WithEvents top_border As PictureBox
    Friend WithEvents bottom_border As PictureBox
    Friend WithEvents right_border As PictureBox
    Friend WithEvents left_border As PictureBox
    Friend WithEvents gravity As Timer
    Friend WithEvents jump As Timer
    Friend WithEvents go_right As Timer
    Friend WithEvents go_left As Timer
    Friend WithEvents jump_height As PictureBox
    Friend WithEvents green_sprite As PictureBox
    Friend WithEvents yellow_sprite As PictureBox
    Friend WithEvents black_sprite As PictureBox
    Friend WithEvents coin As PictureBox
    Friend WithEvents randomize As Timer
    Friend WithEvents random_lbl As Label
    Friend WithEvents redsprite As Timer
    Friend WithEvents animation_fall As Timer
    Friend WithEvents red_sprite As PictureBox
    Friend WithEvents time_frame As Label
    Friend WithEvents greensprite As Timer
    Friend WithEvents blacksprite As Timer
    Friend WithEvents yellowsprite As Timer
    Friend WithEvents coin_ As Timer
    Friend WithEvents healthbar_base As PictureBox
    Friend WithEvents player_healthbar As PictureBox
    Friend WithEvents player_health_lbl As Label
    Friend WithEvents display_damage_lbl As Label
    Friend WithEvents died_animation As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents coins_counter As Label
    Friend WithEvents game_Timer_lbl As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents game_Timer As Timer
    Friend WithEvents display_menu_lbl As Label
    Friend WithEvents display_menu_lbl2 As Label
    Friend WithEvents display_menu_help As Label
    Friend WithEvents help_menu As PictureBox
    Friend WithEvents close_menu_lbl As Label
    Friend WithEvents version_lbl As Label
End Class
