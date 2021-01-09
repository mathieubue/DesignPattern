using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Part2
{
	class Program
	{
		private static readonly FileInfo InputFile = new FileInfo("data.txt");
		private static char[] separator = { ' '};
		static void Main(string[] args)
		{
			Console.WriteLine("Starting ... ");
			IDictionary<string, int> words;
			words = GetResult();
			print_result(words);


		
		}

		private static IDictionary<string, int> GetResult()
		{
			var result = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
			Parallel.ForEach(
				File.ReadLines(InputFile.FullName)/*Spliting*/,
				new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
				() => new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase),
				(line, state, localDic) =>
				{
					foreach (var word in line.Split(separator, StringSplitOptions.RemoveEmptyEntries))
					{
						Map(localDic, word);//Mapping
					}
					return localDic;
				},
				localDic =>
				{
					lock (result)
					{
						Reduce(result, localDic);//Reducing
					}
				}
			);

			return result; //final Result
		}

		private static void Reduce(Dictionary<string,int> result, Dictionary<string, int> localDic)
		{
			foreach (var pair in localDic)
			{
				var key = pair.Key;
				if (result.ContainsKey(key))
				{
					result[key] += pair.Value;
				}
				else
				{
					result[key] = pair.Value;
				}
			}
		}

		private static void Map(IDictionary<string, int> wordCounts, string word)
		{
			if (wordCounts.TryGetValue(word, out int count))
			{
				wordCounts[word] = count + 1;
			}
			else
			{
				wordCounts[word] = 1;
			}
		}


		private static void print_result(IDictionary<string, int> result)
		{
			foreach (var word in result)
			{
				Console.WriteLine(word.Key + " , " + word.Value.ToString());
			}
		}

	}
}
