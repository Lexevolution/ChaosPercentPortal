' Chaos% originally by hadot. Recreated by thingamajig0.
Public Class Form1
    ' Just some variables for use pretty much everywhere...
    Public Shared c_on As New List(Of List(Of String))
    Public Shared c_off As New List(Of String)
    Public Shared tog As New Byte
    Public Shared param_reset As New Boolean
    Public Shared param_wait As New Boolean
    Public Shared waitcommand As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
        CCommand.Hide()
        ' tog is a toggle for whether the commands run are the reset ones or not.
        tog = 0
        ' Just checking whether the config exists, to initiate first time setup
        Dim firsttime As Boolean = IO.File.Exists("ChaosConfig.txt")
        If firsttime = True Then
        Else
nocancel:   ' Some pretty self-explanatory stuff...
            Dim result As Integer = MsgBox("'ChaosConfig.txt' was not found. So first time setup will run", vbOKCancel, "First Time Setup")
            If result = MsgBoxResult.Ok Then
                MsgBox("As some people have different default values for these" & vbNewLine & "settings, you will need to provide them.", vbOKOnly, "First Time Setup")

                Dim fov As String = InputBox("What is your FOV? (Default is 75)", "First Time Setup", "75")
                If fov = "" Then
                    MsgBox("First time setup will restart." & vbNewLine & "If you want to quit, click cancel on the next dialog box.", vbOKOnly, "First Time Setup")
                    GoTo nocancel
                End If

                Dim m_yaw As String = InputBox("What is your m_yaw set to? (Default is 0.022)", "First Time Setup", "0.022")
                If m_yaw = "" Then
                    MsgBox("First time setup will restart." & vbNewLine & "If you want to quit, click cancel on the next dialog box.", vbOKOnly, "First Time Setup")
                    GoTo nocancel
                End If

                Dim viewmodel_fov As String = InputBox("What is your viewmodel_fov set to? (Default is 54)", "First Time Setup", "54")
                If viewmodel_fov = "" Then
                    MsgBox("First time setup will restart." & vbNewLine & "If you want to quit, click cancel on the next dialog box.", vbOKOnly, "First Time Setup")
                    GoTo nocancel
                End If

                Dim confdir As String
selectcfg:
                ' Choosing the config folder, because finding it automatically would suck to code.
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    confdir = FolderBrowserDialog1.SelectedPath
                    Dim folders As String() = Split(confdir, "\")
                    ' Checks whether someone was stupid enough to choose another folder. :P
                    If folders.Last() = "cfg" Then
                    Else
                        MsgBox("Please select the folder named 'cfg', not '" & folders.Last() & "'.")
                        GoTo selectcfg
                    End If
                Else
                    MsgBox("First time setup will restart." & vbNewLine & "If you want to quit, click cancel on the next dialog box.", vbOKOnly, "First Time Setup")
                    GoTo nocancel
                End If

                Dim config = IO.File.Create("ChaosConfig.txt")
                config.Close()
                ' The longest single line piece of code I've ever written. This has all of the config data in it.
                Dim Data As String() = {"#The Default Settings", "Defaults:", "Directory=" & confdir, "", "#All the options you can view in the options menu", "Options:", "Streamer=False", "Popup=True", "", "#Add your commands here", "Commands:", "!!RESET", "crosshair 0", "say NO CROSSHAIR", "", "!!RESET", "r_drawworld 0", "say NO DRAW LOL", "", "!!RESET", "m_yaw 2", "say 0 to 100 REAL FUCKIN QUICK", "", "!!RESET", "r_drawothermodels 2", "say IS THAT WALLHACK?!? OMFG VAC VAC VAC", "", "kill", "lol killd", "", "!!RESET", "mat_reversedepth 1", "say UR LIFE IS INVERTED", "", "spike;spike", "say BIT OF LAG THERE, RIP UR INTEL INTERGRATED GRAPHICS", "", "!!RESET", "mat_motion_blur_enabled 1; mat_motion_blur_rotation_intensity 200; mat_motion_blur_strength 200", "say its like mario kart for ADULTS", "", "!!RESET", "fov 177", "say WoOOoOooOooaoaooaooooaoaeoooaeoaoeaoeooaoaoeooahhhhh", "", "!!RESET", "r_depthoverlay 1; r_showz_power 5", "say bit of FOG AY??!?!?", "", "!!RESET", "r_farz 128", "say NICE 128 HAMMER UNIT VIEW DISTANCE YOU MOLE", "", "!!RESET", "mat_Wireframe 1", "say WALLHACKS!!!!!!!!!!!!!!!!!!! TELLING VAC DADDY GAPE", "", "!!RESET", "sv_gravity 3500", "say omg HOW FAT ARE YOU, YOU CANT JUMP!!!!!!", "", "!!RESET", "sv_gravity 200", "say omg LOL U ON THE MOON OR WHAT BRO", "", "!!RESET", "mat_showlowresimage 1", "say bad jpg bro", "", "!!RESET", "r_shader_srgb 1", "say DID IT GET DARK IN HERE OR IS IT JUST ME", "", "!!RESET", "mat_proxy 2", "say STOP THE WALLHACK OMG", "", "!!RESET", "mat_luxels 1", "say A problem has been detected and Portal has been shut down to prevent damage to your computer. STOP: 0x00000050 (0xCHAOS023,0x00000001,0XFBFE7617,0X00000000)", "", "!!RESET", "r_showenvcubemap 1", "say GOOGLE CHROME????", "", "!!RESET", "mat_fullbright 2", "say GIMME BACK MY TEXTURES", "", "!!RESET", "mat_fullbright 1", "say TURN DOWN THE FRICKIN LIGHTS", "", "!!RESET", "mat_surfaceid 1", "say BIT DISTRACTED", "", "!!RESET", "r_screenoverlay effects/tp_eyefx/tp_eyefx.vmt", "say hahahahaha fuck!", "", "!!RESET", "mat_depthbias_normal 1", "say !!!!!!!!!!!!!! FUCK", "", "!!RESET", "thirdperson", "say woop woop 3rd PERSON", "", "!!RESET", "_y_spt_setpitch 800", "say YOUR SHOE LACE IS UNTIED!!!!", "", "hurtme 99", "say MY HP >:C", "", "simple_bot_add", "say who dat who dat iggy", "", "!!RESET", "+showbudget;+showbudget_texture_global", "say DE DE DE DE BUG", "", "reload", "", "!!RESET", "+showscores", "say THERES ONE WHITE BOX WHAT ARE YOU DOING", "", "!!RESET", "snd_show 1", "say SOUND DEBUG WHADDUP", "", "restart", "", "ent_create_portal_metal_sphere", "say WOAH BALLS", "", "ent_create_portal_weight_box", "say WOAH CUBES LIKE MINECRAFT", "", "!!RESET", "lookstrafe 1", "say u dont wanna move side to side WHY?", "", "fire_energy_ball", "say IMANEX LOVES BALLS", "", "createhairball", "say *cough cough*", "", "!!WAIT", "save chaos", "say bye bye", "map testchmb_a_00", "load chaos", "", "!!RESET", "cl_yawspeed 900;+left", "say LEFTY LOOSEY", "", "!!RESET", "cl_yawspeed 900;+right", "say RIGHTY TIGHTY", "", "!!RESET", "host_timescale 1.2", "say SUPER SONIC", "", "!!RESET", "host_timescale 0.2", "say SUPER non-SONIC", "", "npc_create npc_headcrab_fast", "say HAVE YOU EVER, EVER FELT LIKE THIS", "", "!!RESET", "sv_portal_placement_never_fail 1", "say SHOOT THE NON WHITE WALLS I FUCKIN DARE YOU", "", "!!RESET", "change_portalgun_linkage_id 10", "say PEW PEW FUCK YEW", "", "!!WAIT", "showtriggers_toggle", "say R U TRIGGERED", "showtriggers_toggle", "", "!!RESET", "fov 20", "say CAN YOU SEE YET?!?!?!", "", "!!WAIT", "+duck", "say WHY U SQUATTIN?!?!?", "-duck", "", "!!RESET", "viewmodel_fov 200", "say STRETCH YOUR ARMS", "", "!!RESET", "phys_timescale 10", "say I LOVE PHYSICS", "", "!!WAIT", "+use", "say WHAT?!?!? YOU CANT PICK SHIT UP!?!??!", "-use", "", "!!WAIT", "+jump;y_spt_autojump 0", "say NO MORE JUMPING, NO MORE SCRIPTING", "-jump", "", "!!WAIT", "fadeout", "say SHH GOODNIGHT SWEETIE", "fadein", "", "pause", "say LOL", "", "!!WAIT", "+forward", "say FORWARD SOLDIER", "-forward", "", "ch_createairboat", "say BOAT SON", "", "ent_teleport player", "say INVISIBLE PORTAL OR WHAT", "", "ent_create_portal_weight_box;ent_create_portal_weight_box ;ent_create_portal_weight_box ;ent_create_portal_weight_box;ent_create_portal_weight_box ;ent_create_portal_weight_box", "say BOXES", "", "prop_dynamic_create " & Chr(34) & Chr(34), "say ERROR ERROR ERROR", "", "!!RESET", "hud_quickinfo 0", "say HL2 CROSSHAIR FUKK", "", "prop_physics_create props_c17\furnituretable002a.mdl;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;shake;", "say EARTHQUAKE!! GET UNDER A FUCKIN TABLEEEEEFE", "", "give weapon_frag;use weapon_frag", "say NADESHOT", "", "npc_create npc_cscanner", "say FLASHBANG OR WHAT", "", "npc_create npc_helicopter", "say COPTA COPTER", "", "npc_create npc_turret_floor", "say OOODODODODODODODOOODO", "", "!!RESET", "snd_mixahead 200", "say is ur sound delayed?", "", "!!RESET", "r_aspectratio 6", "say 4:3 streched!!!!", "", "!!RESET", "mat_viewportscale 0.2", "say you will never see this text", "", "!!RESET", "net_Fakelag 150;net_Graph 1", "say NICE 300 PING LOL", "", "clear; echo hello;  echo hello;  echo hello;  echo hello;  echo hello;  echo hello;  echo hello;  echo hello;  echo hello;  echo hello;   toggleconsole", "", "ent_create npc_portal_turret_floor", "say CONE", "", "!!RESET", "sv_player_funnel_into_portals 0", "say FUNNEL HEAD", "", "prop_dynamic_create props\cake\cake.mdl", "say CAKE CUNT", "", "ent_remove", "say REMOVED CUNT", "", "!!RESET", "mat_normalmaps 1", "say what do you call this", "", "!!RESET", "r_portal_stencil_depth " & Chr(34) & "0" & Chr(34), "say PORATLS GONE LOL", "", "!!RESET", "player_throwforce -50000", "say YOU ARE BAD AT THROWING", "", "!!RESET", "player_throwforce 10000000", "say YOU ARE GOOOD AT THROWING", "", "!!RESET", "r_visualizelighttraces 1; r_visualizetraces 1", "say what do you call this?", "", "CreateHairball", "say sir do you like a hair ball mate", "", "#If your commands need resetting, add the reset command here", "Reset:", "crosshair 1", "r_drawworld 1", "r_drawothermodels 1", "r_visualizetraces 0; r_visualizelighttraces 0", "mat_reversedepth 0", "r_depthoverlay 0; r_showz_power 1.0f", "r_farz -1", "mat_wireframe 0", "sv_gravity 600", "mat_showlowresimage 0", "r_shader_srgb 0", "mat_proxy 0", "mat_luxels 0", "r_showenvcubemap 0", "mat_fullbright 0", "r_screenoverlay " & Chr(34) & Chr(34), "mat_depthbias_normal 0", "firstperson", "-showbudget;-showbudget_texture_global", "-showscores", "snd_show 0", "cl_yawspeed 210;-left", "cl_yawspeed 210;-right", "host_timescale 1", "sv_portal_placement_never_fail 0", "change_portalgun_linkage_id 0", "viewmodel_fov 54", "phys_timescale 1", "-attack", "hud_quickinfo 1", "snd_mixahead 0.1", "r_aspectratio 0", "mat_viewportscale 1", "net_Fakelag 0", "lookstrafe 0", "mat_motion_blur_enabled 0; mat_motion_blur_rotation_intensity 1; mat_motion_blur_strength 1", "sv_player_funnel_into_portals 1", "r_portal_stencil_depth " & Chr(34) & "2" & Chr(34), "player_throwforce 1000", "mat_normalmaps 0", "fov " & fov, "m_yaw " & m_yaw, "viewmodel_fov " & viewmodel_fov, "#end"}

                IO.File.WriteAllLines("ChaosConfig.txt", Data)

            Else
                ' Because cancelling during the first time setup would initially crash...
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub ChaosStartButton_Click(sender As Object, e As EventArgs) Handles ChaosStartButton.Click
        Dim Chaos As Boolean = False
        ' TOTALLY the best way to check whether you've clicked the start button...
        If ChaosStartButton.Text = "Start The Chaos!" Then
            c_on.Clear()
            c_off.Clear()
            tog = 0
            OptionsButton.Hide()
            CCommand.Show()
            ChaosStartButton.Text = "Stop The Chaos!"
            Chaos = True
            Dim config As String() = IO.File.ReadAllLines("ChaosConfig.txt")
            Dim CommCheck As Boolean = False
            Dim count As Integer = 0
            Dim varnum As Integer = 0
            Dim comm As New List(Of String)

            ' This whole for loop is for adding the command sets to the program
            For i = 0 To config.GetUpperBound(0)
                ' Enables making comments in the config file. 
                Dim comment As Boolean = config(i).Contains("#")
                ' This separates each command set in to its own list (comm), then adds each list to another list (c_on). LISTCEPTION!
                If CommCheck = True And comment = False Then
                    ' Checks for the spacing between command sets.
                    If config(i) = "" Then
                        c_on.Add(comm)
                        comm = New List(Of String)
                        ' Skips adding the blank line in to the command set
                        i = i + 1
                    End If
                    comm.Add(config(i))
                End If

                ' Decides when the command sets start and finish
                If config(i) = "Commands:" Then
                    CommCheck = True
                ElseIf config(i) = "Reset:"
                    CommCheck = False
                End If

            Next

            CommCheck = False

            ' This for loop adds the reset commands to a list (c_off)
            For i = 0 To config.GetUpperBound(0)
                If config(i) = "Reset:" Then
                    CommCheck = True
                    i = i + 1
                ElseIf config(i) = "#end"
                    CommCheck = False
                End If

                If CommCheck = True Then
                    c_off.Add(config(i))
                End If
            Next

            ' Creates the config files required for the commands to activate 'automagically'.
            For i = 0 To config.GetUpperBound(0)
                ' Finds where you set the directory for the cfg folder
                If config(i).Contains("Directory=") Then
                    Dim confdir As String
                    confdir = Replace(config(i), "Directory=", "")
                    Dim chaosconfig = IO.File.Create(confdir & "\chaos.cfg")
                    Dim chaoscomm = IO.File.Create(confdir & "\chaosCommands.cfg")
                    chaosconfig.Close()
                    chaoscomm.Close()
                    ' Writes some stuff necessary for the startup of chaos%
                    IO.File.WriteAllText(confdir & "\chaos.cfg", "bind t " & Chr(34) & "exec chaosCommands.cfg" & Chr(34) & "; sv_cheats 1;")
                End If
            Next

            ' Simple instructions on how to start up chaos%
            For i = 0 To config.GetUpperBound(0)
                If config(i).Contains("Popup=True") = True Then
                    Dim result As Integer = MsgBox("Now get in to a game and type in the console " & Chr(34) & "exec chaos.cfg" & Chr(34) & " to start the chaos!" & vbNewLine & "(Pressing Cancel or X will make this popup never show again)", vbOKCancel)
                    If result = MsgBoxResult.Cancel Then
                        config(i) = "Popup=False"
                        Options.PopupToggle.Checked = False
                        IO.File.WriteAllLines("ChaosConfig.txt", config)
                    End If
                End If
            Next
            ' Timer1.Start() | That's it.
            Timer1.Start()
        Else
            ' STAHP PLZ GAEM BORKED!!! (I just hope no-one stops it midway through a command... That'll be funny.)
            Timer1.Stop()
            CCommand.Hide()
            OptionsButton.Show()
            ChaosStartButton.Text = "Start The Chaos!"
        End If

    End Sub

    ' Self-Explanatory
    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        Options.Show()
        Hide()
    End Sub

    ' The juicy stuff (Note: Not actually juicy)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rng As New Random
        Dim commands As List(Of String)
        Dim config As String() = IO.File.ReadAllLines("ChaosConfig.txt")
        Dim confdir As String = ""

        For i = 0 To config.GetUpperBound(0)
            If config(i).Contains("Directory=") Then
                confdir = Replace(config(i), "Directory=", "")
            End If
        Next

        ' tog: 0 = Set Command, 1 = Activate Command, 2 = Reset Command
        If tog = 2 Then
            If param_reset = True Then
                IO.File.WriteAllLines(confdir & "\chaosCommands.cfg", c_off.ToArray)
                CCommand.Text = "Current Command: "
                InputHelper.PressKey(Keys.T, True)
            ElseIf param_wait = True
                IO.File.WriteAllText(confdir & "\chaosCommands.cfg", waitcommand)
                CCommand.Text = "Current Command: "
                InputHelper.PressKey(Keys.T, True)
            End If
            CCommand.Text = "Current Command: "
            tog = 0
            Timer1.Interval = 5000

        ElseIf tog = 1
            CCommand.Text = ("Current Command: " & commands.First)
            InputHelper.PressKey(Keys.T, True)
            Timer1.Interval = 15000

        ElseIf tog = 0
            ' LOST THE RUN TO RNG DUDE!!!! (Randomly chooses command set)
            Dim ltr As Integer = 0
            ltr = rng.Next(c_on.Count)
            commands = c_on(ltr)
            ' Checks randomly chosen command set for parameters
            param_reset = commands.Contains("!!RESET")
            param_wait = commands.Contains("!!WAIT")
            If param_reset = True Then
                commands.Remove("!!RESET")
            End If
            If param_wait = True Then
                commands.Remove("!!WAIT")
                waitcommand = commands.Last()
                commands.Remove(commands.Last())
            End If

            IO.File.WriteAllLines(confdir & "\chaosCommands.cfg", commands.ToArray)
            IO.File.WriteAllText("StreamCommands.txt", commands.First)
            tog = 1
            Timer1.Interval = 10000
        End If
    End Sub

End Class
' Haven't commented on any other form yet... Will get to doing that eventually. (Said every coder ever)
