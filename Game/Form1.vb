'Program developed  by Brandon Lombard
'If using for business or personal use, please cite the author.

'VB.NET Windows Form App
'Block Game

'For this program, I decided to mainly focus on using timers in order to make
'smooth animations / animate some of the sprites(bad guys). The player can
'go right, left, and jump.  There is a point system where the player can obtain
'a score by collecting coins. The player also has a health bar that can be 
'damaged or healed depending on which sprite hits you.


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Display main start menu
        display_damage_lbl.Text = "Block Game"
        'Makes sure start menu top text is centered over sub menu options
        display_damage_lbl.Left = 225
        'Ensures all are visible and player is not visible until game is started
        display_damage_lbl.Visible = True
        display_menu_lbl.Text = "Start"
        display_menu_lbl.Visible = True
        display_menu_lbl2.Text = "Quit"
        display_menu_lbl2.Visible = True
        display_menu_help.Text = "Help"
        display_menu_help.Visible = True
        time_frame.Text = "starting"
        close_menu_lbl.Visible = False
        player.Visible = False
        'Help menu picturebox not visible on form load
        help_menu.Visible = False
        'Ensure player can't see unnecessarry labels
        'Time frrame sequence hidden
        time_frame.Visible = False
        'Random sprite values for randomize label
        random_lbl.Visible = False
    End Sub

    Private Sub user_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Dim gravity_memory As Integer 'Gravity memory keeps track if player is falling or not
        ' This program uses timers to animate key presses into player actions
        If time_frame.Text = "playing" Then
            If e.KeyCode = Keys.Up Then
                jump.Enabled = True
                'If statement to make sure gravity and jump don't interfere
                If gravity.Enabled = True Then
                    gravity.Enabled = False
                End If
            ElseIf e.KeyCode = Keys.Down Then
                If player.Height = 41 Then
                    player.Height = 31
                    player.Top = player.Top - 10
                Else
                    player.Height = 41
                    player.Top = player.Top + 10
                End If
            ElseIf e.KeyCode = Keys.Right Then
                go_right.Enabled = True
            ElseIf e.KeyCode = Keys.Left Then
                go_left.Enabled = True
            ElseIf e.KeyCode = Keys.Escape Then
                If time_frame.Text = "paused" Or time_frame.Text = "paused1" Then
                    time_frame.Text = "playing"
                ElseIf time_frame.Text = "playing" Then
                    time_frame.Text = "paused"
                End If
            ElseIf e.KeyCode = Keys.W Then
                jump.Enabled = True
                'If statement to make sure gravity and jump don't interfere
                If gravity.Enabled = True Then
                    gravity.Enabled = False
                End If
            ElseIf e.KeyCode = Keys.D Then
                go_right.Enabled = True
            ElseIf e.KeyCode = Keys.A Then
                go_left.Enabled = True
            ElseIf e.KeyCode = Keys.P Then

                If time_frame.Text = "paused" Or time_frame.Text = "paused1" Then
                    time_frame.Text = "playing"
                ElseIf time_frame.Text = "playing" Then
                    time_frame.Text = "paused"
                End If



            End If

        ElseIf time_frame.Text = "dead" Then

        ElseIf time_frame.Text = "paused" Then


        End If

        'paused1 is when the game is unpaused
        If time_frame.Text = "paused1" Then
            If gravity_memory = 1 Then
                jump.Enabled = False
                gravity.Enabled = True
                gravity_memory = 3
            End If
            If gravity_memory = 0 Then
                jump.Enabled = True
                gravity.Enabled = False
                gravity_memory = 3
            Else
                'Else nothing happens
            End If

            'Ensure that the game timers get started back up to continue gaem
            'and unpause
            game_clock.Enabled = True
            randomize.Enabled = True
            greensprite.Enabled = True
            redsprite.Enabled = True
            yellowsprite.Enabled = True
            blacksprite.Enabled = True
            coin_.Enabled = True
            game_Timer.Enabled = True

            'Hide menu labels because game is unpaused
            display_damage_lbl.Text = ""
            display_menu_lbl.Visible = False
            display_menu_lbl2.Visible = False
            display_menu_help.Visible = False
            time_frame.Text = "playing"
            version_lbl.Visible = False
        End If

        'This If statement is for when the game gets paused
        If time_frame.Text = "paused" Then
            If gravity.Enabled = True Then
                gravity_memory = 1
            End If
            If jump.Enabled = True Then
                gravity_memory = 0
            End If
            display_damage_lbl.Visible = True
            version_lbl.Visible = True
            'Displays "Paused on damage label and sets the location to
            'left of 260 to center over other menu options
            display_damage_lbl.Text = "Paused"
            display_damage_lbl.Left = 260

            'Disable all game timers so game can be fully paused
            game_clock.Enabled = False
            randomize.Enabled = False
            greensprite.Enabled = False
            redsprite.Enabled = False
            yellowsprite.Enabled = False
            blacksprite.Enabled = False
            coin_.Enabled = False
            jump.Enabled = False
            gravity.Enabled = False
            game_Timer.Enabled = False

            'Ensure menu labels are visible and have correct wording
            display_menu_lbl.Visible = True
            display_menu_lbl.Text = "Restart"
            display_menu_lbl2.Visible = True
            display_menu_help.Visible = True
            display_menu_lbl2.Text = "Quit"
            'Next step to unpause when user pressed "P" or "ESC" next
            time_frame.Text = "paused1"
        End If
    End Sub

    Private Sub user_KeyUp(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles Me.KeyUp

        'If key up, stop going right or left
        go_right.Enabled = False
        go_left.Enabled = False

    End Sub


    Private Sub gravity_Tick(sender As Object, e As EventArgs) Handles gravity.Tick

        'Player gravity algorithm
        'If player comes into contact with the bottom border
        player.Location = New Point(player.Location.X, player.Location.Y + 5)
        If player.Bounds.IntersectsWith(bottom_border.Bounds) Then
            'Turn gravity off if player touches bottom border
            ' TEMP: player.Location = New Point(player.Location.Y - 5, player.Location.X - 0)

            'When player intersects with ground, it pushes him up a few pixels to add an animated feel to the
            'player landing.  See animation_fall Timer.
            animation_fall.Enabled = True
            gravity.Enabled = False
        End If

    End Sub

    Private Sub go_right_Tick(sender As Object, e As EventArgs) Handles go_right.Tick

        'Player goes right 
        player.Location = New Point(player.Location.X + 2, player.Location.Y + 0)

    End Sub

    Private Sub go_left_Tick(sender As Object, e As EventArgs) Handles go_left.Tick

        'Player goes left
        player.Location = New Point(player.Location.X - 2, player.Location.Y + 0)

    End Sub

    Private Sub jump_Tick(sender As Object, e As EventArgs) Handles jump.Tick

        'Player jump timer
        player.Location = New Point(player.Location.X, player.Location.Y - 5)

        'If player touches the max jump height picturebox, gravity timer is enabled and jump timer is disabled.
        If player.Bounds.IntersectsWith(jump_height.Bounds) Then
            gravity.Enabled = True
            jump.Enabled = False
        End If

    End Sub

    Private Sub randomize_Tick(sender As Object, e As EventArgs) Handles randomize.Tick

        'Sets random values between 0-5 in randomValue.  This makes it so it sends random
        'sprites towards the player.
        Dim randomValue As Integer
        randomValue = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0

        'TEMPORARY: Lets programmer view the current random number
        random_lbl.Text = randomValue

        If randomValue = 1 Then
            'Red sprite released
            redsprite.Enabled = True
        ElseIf randomValue = 2 Then
            'Green sprite released
            greensprite.Enabled = True
        ElseIf randomValue = 3 Then
            'Yellow sprite released
            yellowsprite.Enabled = True
        ElseIf randomValue = 4 Then
            'Black sprite released
            blacksprite.Enabled = True
        ElseIf randomValue = 5 Then
            'Coin released
            coin_.Enabled = True
        Else

        End If


    End Sub

    Private Sub animation_fall_Tick(sender As Object, e As EventArgs) Handles animation_fall.Tick

        'When player intersects with ground, it pushes him up a few pixels to add an animated feel to the
        'player landing.
        Dim up_counter As Integer
        If player.Bounds.IntersectsWith(bottom_border.Bounds) Then
            player.Location = New Point(player.Location.X - 0, player.Location.Y - 2)
            up_counter = 0

        End If
        'Make sure it only does this once


        If up_counter = 2 Then
            animation_fall.Enabled = False
            up_counter = 0
        End If

    End Sub

    Private Sub game_clock_Tick(sender As Object, e As EventArgs) Handles game_clock.Tick
        'Main game clock
        display_damage_lbl.Visible = False
        'This code handles damage and coins if player intersects with sprites.

        'Convert label into an Int
        Dim game_Timer_Int As Integer = game_Timer_lbl.Text

        'If statements to make the game go faster every set period of time
        If game_Timer_Int < 30 Then

        End If
        'Between 30 and 45 seconds makes faster timer intervals
        If game_Timer_Int >= 30 And game_Timer_Int < 45 Then
            redsprite.Interval = 100
            greensprite.Interval = 100
            blacksprite.Interval = 100
            yellowsprite.Interval = 100
        End If
        'Between 45 and 60 seconds makes faster timer intervals
        If game_Timer_Int >= 45 And game_Timer_Int < 60 Then
            redsprite.Interval = 50
            greensprite.Interval = 50
            blacksprite.Interval = 50
            yellowsprite.Interval = 50
        End If
        'Between 60 and 75 seconds makes faster timer intervals
        If game_Timer_Int >= 60 And game_Timer_Int < 75 Then
            redsprite.Interval = 25
            greensprite.Interval = 25
            blacksprite.Interval = 25
            yellowsprite.Interval = 25
            randomize.Interval = 100
        End If
        'Between 75 and 90 seconds makes faster timer intervals
        If game_Timer_Int >= 75 And game_Timer_Int < 90 Then
            redsprite.Interval = 12
            greensprite.Interval = 12
            blacksprite.Interval = 12
            yellowsprite.Interval = 12
            randomize.Interval = 100
        End If
        'Between 90 and 105 seconds makes faster timer intervals
        If game_Timer_Int >= 90 And game_Timer_Int < 105 Then
            redsprite.Interval = 5
            greensprite.Interval = 5
            blacksprite.Interval = 5
            yellowsprite.Interval = 5
            randomize.Interval = 10
        End If
        'Between 105 and 120 seconds makes faster timer intervals
        If game_Timer_Int >= 105 And game_Timer_Int < 120 Then
            redsprite.Interval = 1
            greensprite.Interval = 1
            blacksprite.Interval = 1
            yellowsprite.Interval = 1
            randomize.Interval = 10
        End If
        'If gae timer set to equal to or above 120 then at fastest setting in game
        If game_Timer_Int >= 120 Then
            redsprite.Interval = 1
            greensprite.Interval = 1
            blacksprite.Interval = 1
            yellowsprite.Interval = 1
            randomize.Interval = 1
        End If



        If red_sprite.Bounds.IntersectsWith(player.Bounds) Then
            'If red sprite touches player, daage is dealt to the player and health bar updated
            player_health_lbl.Text = player_health_lbl.Text - 20
            display_damage_lbl.Text = "-20"
            display_damage_lbl.Visible = True
            player_healthbar.Width = player_health_lbl.Text


        ElseIf yellow_sprite.Bounds.IntersectsWith(player.Bounds) Then
            'If yellow sprite touches player, damage is dealt to the player and health bar updated
            player_health_lbl.Text = player_health_lbl.Text - 15
            display_damage_lbl.Text = "-15"
            display_damage_lbl.Visible = True
            player_healthbar.Width = player_health_lbl.Text

        ElseIf black_sprite.Bounds.IntersectsWith(player.Bounds) Then
            'If black sprite touches player, damage is dealt to the player and health bar updated
            player_health_lbl.Text = player_health_lbl.Text - 50
            display_damage_lbl.Text = "-50"
            display_damage_lbl.Visible = True
            player_healthbar.Width = player_health_lbl.Text

        ElseIf green_sprite.Bounds.IntersectsWith(player.Bounds) Then
            'If green sprite touches player, damage is dealt to the player and health bar updated
            player_health_lbl.Text = player_health_lbl.Text - 10
            display_damage_lbl.Text = "-10"
            display_damage_lbl.Visible = True
            player_healthbar.Width = player_health_lbl.Text

        ElseIf coin.Bounds.IntersectsWith(player.Bounds) Then
            'Add 1 to coins_counter if player touches a coin and resets coin position
            coins_counter.Text = coins_counter.Text + 1
            coin.Left = 650
            coin_.Enabled = False
        End If

        'If player health bar runs out, player will die and menu will pop up with options
        'to restart / quit / get help
        If player_health_lbl.Text <= 0 Then
            player_health_lbl.Text = 0
            'display_damage_lbl.Visible = False
            time_frame.Text = "dead"
            display_damage_lbl.Left = 255
            display_damage_lbl.Text = "You Died"
            display_menu_lbl.Text = "Play Again"
            display_menu_lbl2.Text = "Quit"
            display_menu_lbl.Visible = True
            display_menu_lbl2.Visible = True
            died_animation.Enabled = True
            game_Timer.Enabled = False
            game_clock.Enabled = False
        End If

    End Sub

    Private Sub redsprite_Tick(sender As Object, e As EventArgs) Handles redsprite.Tick
        'Red sprite (bad guy) animation timer
        Dim values_comparator As Integer = 0
        values_comparator = 1
        If values_comparator = 1 Then
            'Move red sprite left
            red_sprite.Left = red_sprite.Left - 5
            'If red sprite intersects with left border, it resets to the right of the program
            If red_sprite.Bounds.IntersectsWith(left_border.Bounds) Then
                red_sprite.Left = 650
                values_comparator = 0
                red_sprite.Enabled = False
            End If

        End If

    End Sub

    Private Sub greensprite_Tick(sender As Object, e As EventArgs) Handles greensprite.Tick
        'Green sprite (bad guy) animation timer
        Dim values_comparator As Integer = 0
        values_comparator = 1
        If values_comparator = 1 Then
            'Move green sprite left
            green_sprite.Left = green_sprite.Left - 15
            'If green sprite intersects with left border, it resets to the right of the program
            If green_sprite.Bounds.IntersectsWith(left_border.Bounds) Then
                green_sprite.Left = 650
                values_comparator = 0
                greensprite.Enabled = False
            End If
        End If

    End Sub

    Private Sub blacksprite_Tick(sender As Object, e As EventArgs) Handles blacksprite.Tick
        'Black sprite (bad guy) animation timer
        Dim values_comparator As Integer = 0
        values_comparator = 1
        If values_comparator = 1 Then
            'This randomValue code amkes it so the black sprite starts and stops randomly,
            'making it more difficult for the player to avoid it.
            Dim randomValue As Integer
            randomValue = CInt(Math.Floor((2 - 0 + 1) * Rnd())) + 0
            If randomValue = 1 Then
                black_sprite.Left = black_sprite.Left - 5
            ElseIf randomValue = 2 Then
                black_sprite.Left = black_sprite.Left - 0
            Else
                black_sprite.Left = black_sprite.Left - 3
            End If
            'If black sprite intersects with left border, it resets to the right of the program
            If black_sprite.Bounds.IntersectsWith(left_border.Bounds) Then
                black_sprite.Left = 650
                values_comparator = 0
                blacksprite.Enabled = False
            End If
        End If

    End Sub

    Private Sub yellowsprite_Tick(sender As Object, e As EventArgs) Handles yellowsprite.Tick
        'Yellow sprite (bad guy) animation timer
        Dim values_comparator As Integer = 0
        values_comparator = 1
        If values_comparator = 1 Then
            'Move green sprite left
            yellow_sprite.Left = yellow_sprite.Left - 10
            'If green sprite intersects with left border, it resets to the right of the program
            If yellow_sprite.Bounds.IntersectsWith(left_border.Bounds) Then
                yellow_sprite.Left = 650
                values_comparator = 0
                yellowsprite.Enabled = False
            End If
        End If

    End Sub

    Private Sub coin__Tick(sender As Object, e As EventArgs) Handles coin_.Tick
        'Coin animation timer
        Dim values_comparator As Integer = 0
        values_comparator = 1

        If values_comparator = 1 Then
            'Move green sprite left
            coin.Left = coin.Left - 10
            'If coin intersects with left border, it resets to the right of the program
            If coin.Bounds.IntersectsWith(left_border.Bounds) Then
                coin.Left = 650
                values_comparator = 0
                coin_.Enabled = False
            End If
        End If

    End Sub

    Private Sub died_animation_Tick(sender As Object, e As EventArgs) Handles died_animation.Tick
        'Animation for when player dies
        'NOT WORKING YET
        Dim values_comparator As Integer

        If time_frame.Text = "dead2" Then
            If values_comparator = 4 Then
                player.BackColor = Color.Red
                values_comparator = 5
                died_animation.Enabled = False
            End If

            If values_comparator = 3 Then
                player.BackColor = Color.Gray
                values_comparator = 4
            End If

            If values_comparator = 2 Then
                player.BackColor = Color.DarkOliveGreen
                values_comparator = 3
            End If

            If values_comparator = 1 Then
                player.BackColor = Color.ForestGreen
                values_comparator = 2
            End If
        End If

        If time_frame.Text = "dead" Then
            values_comparator = 1
            time_frame.Text = "dead2"
        End If

    End Sub

    Private Sub game_Timer_Tick(sender As Object, e As EventArgs) Handles game_Timer.Tick

        'Adds seconds to the timer board
        game_Timer_lbl.Text = game_Timer_lbl.Text + 1

    End Sub

    Private Sub display_menu_lbl_Click(sender As Object, e As EventArgs) Handles display_menu_lbl.Click

        If time_frame.Text = "starting" Then
            'Hide pause and player died menu options on form load
            display_menu_lbl.Visible = False
            display_menu_lbl2.Visible = False
            display_menu_help.Visible = False
            display_damage_lbl.Visible = False
            version_lbl.Visible = False
            'Make player visible now
            player.Visible = True
            'Begin basic game clocks
            game_clock.Enabled = True
            'game_Timer focuses on timing the player to see how long they
            'lasted in the game
            game_Timer.Enabled = True
            'gravity timer makes the player fall
            gravity.Enabled = True
            'randomize timer handles randomizing the enemy block's attacks
            randomize.Enabled = True
            'Make game time_frame set to playing so player can move
            time_frame.Text = "playing"
        Else
            'Menu buton for if the game is paused or player dies
            'Handles restarting the game
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to restart this game?", "Restart Game", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                'Reloads the game
                Me.Controls.Clear() 'removes all the controls on the form
                InitializeComponent() 'load all the controls again
                Form1_Load(e, e) 'Load everything in your form, load event again
            End If
        End If

    End Sub

    Private Sub display_menu_lbl2_Click(sender As Object, e As EventArgs) Handles display_menu_lbl2.Click

        'Menu buton for if the game is paused or player dies
        'Handles Quiting the game and asks the user ig they really want to quit
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit this game?", "Quit Game", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'If user selects "No" then nothing happens
        ElseIf result = DialogResult.Yes Then
            'If user selects "Yes" then the program fully closes
            Me.Close()
        End If

    End Sub

    Private Sub display_menu_help_Click(sender As Object, e As EventArgs) Handles display_menu_help.Click
        'Menu button for if the player wants to get help with commands or game rules
        help_menu.Visible = True
        close_menu_lbl.Visible = True

    End Sub

    Private Sub close_menu_lbl_Click(sender As Object, e As EventArgs) Handles close_menu_lbl.Click

        'Close the menu if label is clicked
        help_menu.Visible = False
        close_menu_lbl.Visible = False

    End Sub
End Class
