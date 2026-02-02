using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        ProcessJson();
        ProcessCsv();
        Console.WriteLine("IPL data censored successfully!");
    }

    static string MaskTeamName(string team)
    {
        var parts = team.Split(' ');
        if (parts.Length >= 2)
            parts[1] = "***";
        return string.Join(" ", parts);
    }

    static void ProcessJson()
    {
        var json = File.ReadAllText("ipl.json");
        var matches = JsonConvert.DeserializeObject<List<IplMatch>>(json);

        foreach (var m in matches)
        {
            string t1 = MaskTeamName(m.team1);
            string t2 = MaskTeamName(m.team2);

            m.score = new Dictionary<string, int>
            {
                { t1, m.score[m.team1] },
                { t2, m.score[m.team2] }
            };

            m.team1 = t1;
            m.team2 = t2;
            m.winner = MaskTeamName(m.winner);
            m.player_of_match = "REDACTED";
        }

        File.WriteAllText("ipl_censored.json",
            JsonConvert.SerializeObject(matches, Formatting.Indented));
    }

    static void ProcessCsv()
    {
        var lines = File.ReadAllLines("ipl.csv");
        var output = new List<string> { lines[0] };

        for (int i = 1; i < lines.Length; i++)
        {
            var cols = lines[i].Split(',');

            cols[1] = MaskTeamName(cols[1]);
            cols[2] = MaskTeamName(cols[2]);
            cols[5] = MaskTeamName(cols[5]);
            cols[6] = "REDACTED";

            output.Add(string.Join(",", cols));
        }

        File.WriteAllLines("ipl_censored.csv", output);
    }
}