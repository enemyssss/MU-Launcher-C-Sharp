# MU-Launcher-C-Sharp
Mu Online Launcher Project in C#
Info:
In Launcher/config.ini -
1. ServerVersion= 0/1 - 0 for old versions like 97d /// 1 for versions season 1+
2. ServerIP-Port=/u127.0.0.1 /p44405 - only if you launch old version like 97d
3.ClientVersionWeb - reads the version set in the web server and compares it to the one in config.ini (Version =).
4.UpdatePath - link to the zip file where the new update is uploaded.

AutoUpdate Settings:
1. Add the contents of the WebFiles folder to your web server.
2. In the ClientFiles / Launcher folder you will find the config.ini file.
3.Version is the client version currently, and ClientVersionWeb is the version set
on the website.When you want to update, change ClientVersionWeb in the file
version.txt on your web server.When the two versions are different, the launcher recognizes,
that there is a version change and downloads the content uploaded to the update.zip file
add the update files to update.zip - there is a Launcher folder in that same file.
There's a file named Config.ini - type the version (Version =) that is on the web server (new version)
