namespace FileNameCleaner
{
    public static class Helpers
    {
        public static string RemoveOtherWords(string original)
        {
            List<string> words = new()
    {
        "[2160p-dv hdr10plus.EAC3 Atmos-en,EAC3-es.Subs-es,en]",
        "-DL.DDP5.1.Atmos.H.264-FLUX.[TheRostrum.net]",
        "10bit Rip 6CH HEVC x265-FLUX [psarips]",
        "10bit Rip 6CH HEVC x265-NTb [psarips]",
        "p.AMZN.WEBRip.800MB.x264-GalaxyRG",
        "DNSP Rip AAC5 1 10bits x265-Rapta",
        "BRip.x264-XEN0N.[TheRostrum.net]",
        "AMZN.WEBRip.800MB.x264-GalaxyRG",
        "p.AMZN.WEB-DL.DDP5.1.H.264-FLUX",
        "p.AMZN.WEB-DL.DDP5.1.H.264-NTb.",
        "p h264 Ac3 Dual Subs][GrupoTS]",
        "VOSTFR Rip x264-Wawacity rsvp",
        "Rip x264-TVSmash [tvu org ru]",
        "Eng Esp Dvdrip Divx-Elzeta",
        "HEVC x265-MeGusta[EZTVx to]",
        "WEB-DL.DD+5.1.H.264-playWEB",
        "HornedSplendidPuduOfFocus",
        "H 264 Multisubs MortFurd",
        ".NF.WEBRip.x264-GalaxyTV",
        "MULTi HDR DV 2160p -FW",
        ".DVDRip.XviD-ALLiANCE",
        "DVDRip.x264-HANDJOB",
        "x265-ELiTE[EZTVx to]",
        "[sharethefiles.com]",
        "P Hevc x265-Megusta",
        "x264-TORRENTGALAXY",
        "P Av1 10Bit-Megusta",
        "RE-ENCODE Rip -NTb",
        "Rip.x264-GalaxyTV",
        "-GloriousMongoose",
        "HEVC x265 MeGusta",
        "Rip x264-GalaxyTV",
        ".UNRATED.EDITION",
        "Atmos H 264-FLUX",
        "(Eng, Esp-Divx5)",
        "[TheRostrum.net]",
        "[ Dual][GrupoTS]",
        "SuccessfulCrab",
        "Rip.x264-RARBG",
        "HDTV x264-FoV",
        "Eng Esp Dvdrip",
        "H264-LAZYCUNTS",
        "H264-DiMEPiECE",
        "HDTV x264-MTB",
        "XviD.AC3-EVO",
        "H264-sexylegs",
        "DDP5.1.H.264",
        "Divx-Elzeta",
        "H264-METCON",
        ".h264-DIANA",
        "h264-EDITH",
        "x264-ION10",
        "H264-CAKES",
        "x264-FENiX",
        "h264-ETHEL",
        "(Xvid-Eng)",
        "h264-KOGi",
        "H264-GGEZ",
        "H 264-NTb",
        "h264-glhf",
        "264-NTb",
        "DDP5.1",
        "WEB-DL",
        "DUBBED",
        "-NHTFS",
        " -RBB",
        "p.AMZN",
        "AMZN",
        "CAKES",
        "DSNP",
        "H264",
        "H265",
        "x264",
        "FLUX",
        "AMZN",
        "MAX",
        "WEB",
        "rip",
        "-DL",
        "DL-",
        "DL",
    };

            words = words.OrderByDescending(x => x.Length).ToList();

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    original = original.Replace(word, "");
            }

            original = original.Replace("..", ".");
            original = original.Replace("..", ".");
            original = original.Replace("..", ".");
            original = original.Replace("..", ".");
            original = original.Replace(".", " ");
            return original.Trim();
        }
    }
}