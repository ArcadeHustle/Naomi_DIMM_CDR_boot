Big thanks to Mitsurugi_w, Darksoft, MetalliC (p1pkin) and Brizzo (Nazarene) of Arcade Projects for finally allowing this to be published. Please direct message them with any questions! https://arcade-projects.com/

- written by hostile, with supporting information from the community at large, and lots of Google searches

<p align="center">
<img src="https://github.com/ArcadeHustle/X3_USB_softmod/blob/master/walsdawg.jpeg"><img src="https://github.com/ArcadeHustle/X3_USB_softmod/blob/master/darksoft.jpeg">
</p>

<p align="center">
  <img src="https://github.com/ArcadeHustle/X3_USB_softmod/blob/master/arcadeprojects.jpeg"><img src="https://github.com/ArcadeHustle/X3_USB_softmod/blob/master/brizzo.jpeg"><img src="https://github.com/ArcadeHustle/X3_USB_softmod/blob/master/metallic.jpg">
</p>

# Stage One:

No, this isn't a Naomi 'multi' announcement!<br>
https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=104055#post104055<br>
"*Gasp* Is this the beginning of the official Naomi 'multi' announcement!!!!!!!!"

Before we get to far into this, a friendly reminder: Please note that the following text is considered "for purposes of good-faith security research".

The above mentioned key players have helped monetize the arcade community via microtransactions for "multicarts", "conversions", and other "fixes" for a few years now. 
This Thanksgiving we've decided to decomission one more part of the ole "Internet Money Maker" by sharing a long lost mythical "CDR" firmware patch for the Naomi GDROM platform. 
<br>TLDR: https://archive.org/download/317hackedupdatergd

The past few years has been spent sowing the arcade scene with misinformation or "white lies" to help supress this sort of detail. It is well beyond time to fess up about this patch,
at this point enough CF readers have been sold. Discussing it is justified, as no private sales will be harmed given they've all tapered off anyway! 

https://www.arcade-projects.com/forums/index.php?thread/11-naomi-cf-kit-and-dimm-conversion-services/
<br>"Naomi Compact Flash Kits------$100 by itself/$125 with a game" only goes so far, you know? 

Please note that the style of soft misinformation tactics used below helps keep the community quiet, these techniques have been very effective at keeping a slow trickle of funding.
 
https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/
<br>"there was no interested enough person, who have skills to hack DIMM firmware, and wants CD support added"

https://www.emu-land.net/forum/index.php?topic=78927.0
<br>"It turns out that SEGA themselves provided for the ability to run from a CD-ROM and the hack just uses this piece of code? Something similar happened with the multi-region BIOS." 

Note the difference? How about here? 

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=104029#post104029
<br>"Anyway this track is dead, no point in using a CD-R which has less capacity than a GD-ROM when we have the CF solution." 

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=104075#post104075
<br>"in my place literally impossible to buy good CD-Rs, but only crap which become unreadable in a days or week after write.
even in online stores it is not easy to find good enough CD-Rs these days, because it is 'dead tech' for a long time already"

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=104077#post104077
<br>"let's admit it. CD-R is a dead technology. If I could choose I would prefer something SD based..And if I could choose More, I'd like a device that replaces the DIMM with newer, less power demanding pcb."

This is called "marketing"! How else could Mitsurugi_w sell so many CF adapters!? There will now be additional DIMM services available to compensate for the losses:

"Convert Normal Dimm to Rev. 3.17 for CDR use-----$25 plus return shipping or free if you purchase a stack of CDROMs at the cash register of Hwy 55 Burgers NC locations" - Contact Mutsurugi_w!

Some of the usage information will be further gatekept, you will need to talk to Mitsurugi_w, or Darksoft directly for more details on creating the appropriate CDROM images. NaoIso.exe should be all you need though.
https://archive.org/download/317hackedupdatergd/NaoIso.exe

Related reading - The Disassembled .NET source version of NaoIso
https://github.com/ArcadeHustle/Naomi_DIMM_CDR_boot/blob/master/disass/NaoISO_VS_Project/NaoIso/Form1.cs<br>
https://github.com/ArcadeHustle/Naomi_DIMM_CDR_boot/blob/master/disass/NaoISO_VS_Project/NaoIso/Form1.Designer.cs

This write up will absolutly give you access to all the previously gatekept firmware you need to make use of archived backups to help preserve your Naomi GDRoms as CDR media.
https://archive.org/download/317hackedupdatergd

Please remember the wise words of Mitsurugi_w "The info itself is not new or special. It's all over the web anyways" 

Additional text relevant to this document can be found below: 

"Internet Archive Gets DMCA Exemption To Help Archive Vintage Software"<br>
"Computer programs and video games distributed in formats that have become obsolete and which require the original media or hardware as a condition of access."
https://archive.org/about/dmca.php

Exemptions to Prohibition against Circumvention of Technological Measures Protecting Copyrighted Works – Seventh 
Triennial Section 1201 Final Rule, Effective October 28, 2018 https://library.osu.edu/document-registry/docs/1027/stream 
"Video games in the form of computer programs, where outside server support has been discontinued, to allow individual 
play and preservation by an eligible library, archive, or museum"

https://library.osu.edu/site/copyright/2019/03/20/2018-dmca-section-1201-exemptions-announced/ "Video games in the 
form of computer programs, lawfully acquired as complete games 37 CFR §201.40(b)(12)" "For personal, local gameplay; 
or To allow preservation in a playable format..."

# Stage Two:

For extended amounts of time now the details of how Sega Naomi can boot games from CDR media has been closely guarded. 

Below is a table showing differences in the binaries that have been available via various channels over the past decade.<br> 
```
Net-Dimm 3.17 flash dump (Originally from https://www.gamoover.net/aspic/1st_FW_Dimm317.rar)
"317_312.bin" (from MAME segadimm.zip - https://archive.org/download/317hackedupdatergd/317_312.bin)
"Hacked Updater GD" (https://archive.org/download/317hackedupdatergd/317hackedupdatergd.bin)
```
------------------------------------------------------------------------------------------------------------------------
```
$ md5 317hackedupdatergd.bin 317_312.bin FW_Dimm317.bin  
MD5 (317hackedupdatergd.bin) = 6150b29fca1ea9cbc465781e2a572739 - Netboot image
MD5 (317_312.bin) = 3db89fa3b5f5be02232d7f70a3e26391 - MAME
MD5 (FW_Dimm317.bin) = b245b4e8f177b1e9c01d47dbbb424aa0  - Raw flash dump 
```
------------------------------------------------------------------------------------------------------------------------

The original 3.17 update GD is archived in MAME as follows:<br>
http://www.citylan.it/wiki/index.php/Naomi_-_Chihiro_-_Triforce<br>
Naomi DIMM Firmware Updater (3.17) 2004.04.22 known internally to MAME as "ngdup23e"<br>
GDS-0023E has encryption key of C775D05831E0B3D3<br>

MAME can be considered important for attempting to understand the "Hacked Updated GD" binary.<br>
https://github.com/mamedev/mame/blob/master/src/mame/machine/naomigd.cpp#L613<br>
"1st MB of flash ROM contain stock version, 2nd MB have some updated version"<br>
"must have CRC32 FFFFFFFF"<br>

All three firmware binaries match from 0x100000 onward with a few minor differences. 

------------------------------------------------------------------------------------------------------------------------
```
Firmware length - 2097152 ( 0x200000 )
FW_Dimm317.bin         | Location          | Bytes
			      0     (0x0)  | 0ed0 0e40 1ca0 0900 0cd0                 ...@.....  # No Netboot ROM header

			 617996  (0x96E0C) | 0000 0000 0000 0000 0000                 .......... # Start of 00's
			
			1048572 (0xFFFFC)  | 1c2d 76ad 0ed0 0e40 1ca0                 .-v....@.. # End of 00's + (crc)
			1048576 (0x100000) | 0ed0 0e40 1ca0 0900 0cd0                 ...@...... # 

			1122363 (0x11203B) | 8df3 6e35 d112 620b e114                 ..n5..b... # 
			1122545 (0x1120F1) | 8d00 e007 d112 6104 e004                 ......a... # 

			2097148 (0x1FFFFC) | 9031 cd30                                .1.0       # CRC
```
------------------------------------------------------------------------------------------------------------------------
```
Firmware length - 2097152 ( 0x200000 )
317_312.bin            | Location          | Bytes
			      0     (0x0)  | 0ed0 0e40 1ca0 0900 0cd0                 ...@.....  # No Netboot ROM header

			 686568 (0xA79E8)  | 0000 0000 0000 0000 0000                 .......... # Start of 00's

			1048572 (0xFFFFC)  | 57ec 49d0 0ed0 0e40 1ca0                 W.I....@.. # End of 00's + (different crc)
			1048576 (0x100000) | 0ed0 0e40 1ca0 0900 0cd0                 ...@...... # 100% Match FW_Dimm317.bin to EOF

			2097148 (0x1FFFFC) | 9031 cd30                                .1.0.      # CRC match FW_Dimm317.bin
```
------------------------------------------------------------------------------------------------------------------------
```
Firmware length - 2097152 ( 0x200000 )
317hackedupdatergd.bin | Location          | Bytes
			      0     (0x0)  | 4e41 4f4d 4920 2020 2020                 NAOMI      # Netboot ROM header

			 248556  (0x3CAEC) | ffff ffff ffff ffff ffff                 .......... # Start of ff's

			1048572 (0xFFFFC)  | ffff ffff 0ed0 0e40 1ca0                 .......@.. # End of ff's + (crc)
			1048576 (0x100000) | 0ed0 0e40 1ca0 0900 0cd0                 ...@...... # 99% Match FW_Dimm317.bin to EOF 

			1122363 (0x11203B) | a0f3 6e35 d112 620b e114                 ..n5..b... # One byte difference
			1122545 (0x1120F1) | a000 e007 d112 6104 e004                 ......a... # One byte difference

			2097148 (0x1FFFFC) | 85c8 3f99                                ..?.       # CRC change
```
------------------------------------------------------------------------------------------------------------------------

The start of 317hackedupdatergd.bin is very similar to FW_Netdimm_402.bin
It is obviously a similar updater, just different version. 

------------------------------------------------------------------------------------------------------------------------
```
317hackedupdatergd.bin | Location          | Bytes
			2016 (0x7E0) | 0000 0000 0317 0000 0000                 ..........
```
------------------------------------------------------------------------------------------------------------------------
vs. 

------------------------------------------------------------------------------------------------------------------------
```
FW_Netdimm_402.bin     | Location          | Bytes
			2016 (0x7E0) | 0000 0000 0402 0000 0000                 ..........
```
------------------------------------------------------------------------------------------------------------------------

All of this has been documented over time, you only need to follow the following trail... 

https://www.emu-land.net/forum/index.php?topic=78927.0<br>
"In the Internet there are rumors about the existence of hack firmware DIMM-board version 3.17 with support for reading CD-ROM. The author is ElSemi."<br>
"it's private, you can not look. although you can try asking around for arcade-projects"<br>
"this hack (the essence - a patch of 2 bytes in the firmware) is available only for a circle of persons who himself was engaged or is engaged in research of Sega DIMM, which can be counted on the fingers of one hand. until Elsemi himself decides to make this hack public - no one else, myself included, will do it himself."

https://www.arcade-projects.com/forums/index.php?thread/1976-quick-about-gd-roms/&postID=25245#post25245<br>
"I've heard some rumours about a soon to release firmware that allows booting from CDR."

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=14622#post14622<br>
"when will the party fixed firmware be released?"

https://www.arcade-projects.com/forums/index.php?thread/854-naomi-dimm-firmware-question/<br>
"From what I understand, the DIMM unit is not compatible with CD-Rs. Apparently there's a modified 3.17 DIMM firmware which is though."

Only one brave soul has come forth to share any *real* detail outside the ranks of a very small circle.  

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=13939#post13939<br>
"Before net booting and CF boooting, there was CD-R booting. You need to patch the DIMM firmware to disable media-check (GD-R vs CD-R) and a few other things, I have tried this myself and it works, somewhat. Unfortunately, at least my setup failed after 1 hour of game-play - probably another mediacheck somehwere that triggered a reset. I'm not aware of anyone managing to patch the firmware properly to avoid the reboot after an hour+.<br>

I have an IDA PRO file timestamped 2008-10-10, which may be it... In any case, I can't take much credit for the firmware as the real details came from Spain..<br>

This is all academic though, and really belongs in the dustbin of history."<br>

He's right! It does... https://archive.org/download/317hackedupdatergd

The rest of the detail belongs in the same historic dustbin, and it shall be left here with no further explaination 

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=13986#post13986<br>
"it will of course not boot without a patched DIMM firmware, as it will check what kind of physical media is in the GD-Drive..". Within the following link is mentioned http://wiki.pcbotaku.com/w/index.php?title=Disc_Layout

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=13992#post13992<br>
"nowdays its simpler... for data extraction from GDI image can be used Japanese Cake's GDROM-Explorer"

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=14685#post14685<br>
"I don't have the gear or inclination to test all this, burn CD-R's to see if it works, then answer questions about why people can't get it to work.. If you really want to have a go at it, I suggest you start disassembling a 3.17 version of the firmware. You're looking for a function called gdachecksecurity IIRC"

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=102796#post102796<br>
"there was unsolved side effects like reset after some time, which makes in ususable at practice, so that hack was abandoned in prior of CF or Net boot methods"

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=102814#post102814<br>
"I also tested some CD-R hacks we wanted to try but they didn't work. This was a year or two ago. It was abandoned very shortly after. I mean, CD-Rs suck anyway."

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=104015#post104015<br>
"So basically it needs further patching, right? Any clue about what could trigger it? Another GDRom check? Timing issues?"

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=104030#post104030<br>
"That reset was patched in the CF version. I guess it can also be easily patched in the GDRom version, if the code that does the check is similar or jumps to similar positions for reset, etc."

https://www.arcade-projects.com/forums/index.php?thread/1159-burn-naomi-games-to-cd-r-and-play-on-gdrom-drive/&postID=104062#post104062<br>
"there is probably some kind of scheduled checks, iirc there is PIC check routine, and disk presence check routine, but I have no good ideas why it may not work for CD-R."

A few more random gems can be found amongst other conversations<br> 
https://forum.arcadeotaku.com/posting.php?mode=quote&f=26&p=409047<br>
"Well id expect now that the bios is hackable then i would i would inject the firmware in the bios and activate it when you go in rom test or similar."

https://forum.arcadeotaku.com/posting.php?mode=quote&f=26&p=410402<br>
"In theory it is possible to hack the 4.02 firm for non net dimm boards in to a regular bios to invoke it from the test mode and hence avoid having to mess around with tsop flashes."

https://forum.arcadeotaku.com/posting.php?mode=quote&f=26&p=481794<br>
"maybe i can take first 1MB from 3.17 firmware and second part from 4.02 updater and merge them to single .bin file using hex editor? Is it work this way?"

The following dumps seem to be the root of much of the public use of DIMM firmware, they are mentioned here for posterity. 
https://forum.arcadeotaku.com/posting.php?mode=quote&f=26&p=410392<br>
"firmware1 (http://www.gamoover.net/aspic/1st_FW_Dimm317.rar) is the bog standard 3.17 - as a flash image ready to burn with a programmer (same md5sum as a flash I desoldered some time back)<br>
firmware2 (http://www.gamoover.net/aspic/2nd_FW_Dimm_402.rar) is a gd-rom/netboot image, which will upgrade the dimm firmware to a patched 4.0 that works with non-net daughterboards."

Finally, the only thing left to mention is that the old Dreamcast "dcisotools" aka gditools may be useful in solving the disc creation. Good luck! If you get stuck, just but Mitsu or Dark. 
https://github.com/einsteinx2/gditools.git

```
$ python gditools.py -l -i /Users/FAD/Downloads/game.gdi 

Parsed gdi file: game.gdi<br>
Base Directory:  /Users/FAD/Downloads<br>
Number of tracks:  3<br>
<br>
DATA track:<br>
	Filename:  game03.bin<br>
	LBA:       45000 <br>
	Mode:      2352 bytes/sector<br>
	Offset:    45000<br>
	WormHole:  [0, 45000, 32]<br>
<br>
Listing all files in the filesystem:<br>
<br>
/<br>
/BEJ.BIN<br>
/IKARUGA.BIN<br>
/NAOMIGD.BIN<br>


             .-"""""""-.
            {      _____}---. .-.
           {      /          (  o\
          {      /            \ \V
          {     |             _\ \.        GOBBLE GOBBLE
           {    |            / '-' \     FUCK A DARKSOFT !!
            {___\   /\______/    __/     ~~~~~~~~~~~~~~~~~
                 ~~/   /    /____//      https://www.youtube.com/watch?v=l0nq1pQXX90
                   '--'\___/ \___/
                           '\_ \_
            _Stitches'19_    /\ /\
```

