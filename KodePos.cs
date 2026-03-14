using System;

public class KodePos
{
	private static Dictionary<string, int> kodeKelurahan = new Dictionary<string, int>
		{
			{"Batununggal",40266},
			{"Kujangsari", 40287},
			{"Mengger", 40267},
			{"Wates", 40256},
			{"Cijaura", 40287},
			{"Jatisari", 40286},
			{"Margasari", 40286},
			{"Sekejati", 40286},
			{"Kebonwaru", 40272},
			{"Maleer", 40274}
		};

	public int getKodePos(string kelurahan)
	{
		int kodePos = 0;
		if (kodeKelurahan.TryGetValue(kelurahan, out kodePos))
		{
			return kodePos;
		}
		else
		{
			Console.WriteLine("Keluaqhan tidak ditemukan.");
			return -1;
		}
	}
}
