
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class Form1
{

	private void Button1_Click(System.Object sender, System.EventArgs e)
	{
		My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\IObit\\Uninstaller", "UninstallerFreeWeb", "1");
		My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\IObit\\Uninstaller", "UninstallerPro", "1");
		Interaction.MsgBox("IObit Uninstaller Successfully Cracked :D");


	}
