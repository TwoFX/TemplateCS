/*
 * TemplateCS
 * Copyright (C) 2014-2016 Markus Himmel
 * This file is distributed under the terms of the MIT license
 */

//#define CodeJam
#define CodeForces

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

// ReSharper disable RedundantUsingDirective
using System.IO;

// ReSharper restore RedundantUsingDirective

// ReSharper disable UnusedMember.Local

// ReSharper disable once CheckNamespace

namespace ProgrammingCompetitions
{
	internal class Program
	{
		#region GCJ

#if CodeJam
		private static bool DEBUG = false;

		static void debug()
		{
		}

		static string solveCase(int num)
		{
			checked
			{
				return null;
			}
		}
#endif

		#endregion

		#region CodeForces

#if CodeForces
#if DEBUG
		private static readonly Queue<string> testInput = new Queue<string>(@"

1 1


".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
#endif

		private static object solve()
		{
			// ReSharper disable once RedundantOverflowCheckingContext
			checked
			{
				return null;
			}
		}
#endif

		#endregion

		// Everything after this comment is template code

		private static T read<T>()
		{
			return (T)Convert.ChangeType(read(), typeof(T));
		}

		private static T[] readMany<T>()
		{
			// ReSharper disable once PossiblyMistakenUseOfParamsMethod
			return readMany<T>(' ');
		}

		private static T[] readMany<T>(params char[] ___)
		{
			return read().Split(___).Select(__ => (T)Convert.ChangeType(__, typeof(T))).ToArray();
		}

		private static string[] readMany()
		{
			return readMany<string>();
		}

		private static T[][] readMany<T>(int n)
		{
			var res = new T[n][];
			for (int i = 0; i < n; i++)
				res[i] = readMany<T>();
			return res;
		}

		private static T[][] readField<T>(int height, Func<char, T> map)
		{
			var res = new T[height][];
			for (int _ = 0; _ < height; _++)
				res[_] = read().Select(map).ToArray();
			return res;
		}

		private static char[][] readField(int height)
		{
			return readField(height, c => c);
		}

		private static T[][] readField<T>(int height, Dictionary<char, T> dic)
		{
			return readField(height, c => dic[c]);
		}

		private static void read<T1>(out T1 t1)
		{
			string[] vals = readMany();
			t1 = (T1)Convert.ChangeType(vals[0], typeof(T1));
		}

		private static void read<T1, T2>(out T1 t1, out T2 t2)
		{
			string[] vals = readMany();
			t1 = (T1)Convert.ChangeType(vals[0], typeof(T1));
			t2 = (T2)Convert.ChangeType(vals[1], typeof(T2));
		}

		private static void read<T1, T2, T3>(out T1 t1, out T2 t2, out T3 t3)
		{
			string[] vals = readMany();
			t1 = (T1)Convert.ChangeType(vals[0], typeof(T1));
			t2 = (T2)Convert.ChangeType(vals[1], typeof(T2));
			t3 = (T3)Convert.ChangeType(vals[2], typeof(T3));
		}

		private static void read<T1, T2, T3, T4>(out T1 t1, out T2 t2, out T3 t3, out T4 t4)
		{
			string[] vals = readMany();
			t1 = (T1)Convert.ChangeType(vals[0], typeof(T1));
			t2 = (T2)Convert.ChangeType(vals[1], typeof(T2));
			t3 = (T3)Convert.ChangeType(vals[2], typeof(T3));
			t4 = (T4)Convert.ChangeType(vals[3], typeof(T4));
		}

		private static void read<T1, T2, T3, T4, T5>(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5)
		{
			string[] vals = readMany();
			t1 = (T1)Convert.ChangeType(vals[0], typeof(T1));
			t2 = (T2)Convert.ChangeType(vals[1], typeof(T2));
			t3 = (T3)Convert.ChangeType(vals[2], typeof(T3));
			t4 = (T4)Convert.ChangeType(vals[3], typeof(T4));
			t5 = (T5)Convert.ChangeType(vals[4], typeof(T5));
		}

		private static Func<T1, TResult> dp<T1, TResult>(Func<T1, Func<T1, TResult>, TResult> f)
		{
			var cache = new Dictionary<Tuple<T1>, TResult>();
			Func<T1, TResult> res = null;
			res = t1 =>
			{
				Tuple<T1> key = Tuple.Create(t1);
				if (!cache.ContainsKey(key))
					cache.Add(key, f(t1, res));
				return cache[key];
			};
			return res;
		}

		private static Func<T1, T2, TResult> dp<T1, T2, TResult>(Func<T1, T2, Func<T1, T2, TResult>, TResult> f)
		{
			var cache = new Dictionary<Tuple<T1, T2>, TResult>();
			Func<T1, T2, TResult> res = null;
			res = (t1, t2) =>
			{
				Tuple<T1, T2> key = Tuple.Create(t1, t2);
				if (!cache.ContainsKey(key))
					cache.Add(key, f(t1, t2, res));
				return cache[key];
			};
			return res;
		}

		private static Func<T1, T2, T3, TResult> dp<T1, T2, T3, TResult>(Func<T1, T2, T3, Func<T1, T2, T3, TResult>, TResult> f)
		{
			var cache = new Dictionary<Tuple<T1, T2, T3>, TResult>();
			Func<T1, T2, T3, TResult> res = null;
			res = (t1, t2, t3) =>
			{
				Tuple<T1, T2, T3> key = Tuple.Create(t1, t2, t3);
				if (!cache.ContainsKey(key))
					cache.Add(key, f(t1, t2, t3, res));
				return cache[key];
			};
			return res;
		}

		private static Func<T1, T2, T3, T4, TResult> dp<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, Func<T1, T2, T3, T4, TResult>, TResult> f)
		{
			var cache = new Dictionary<Tuple<T1, T2, T3, T4>, TResult>();
			Func<T1, T2, T3, T4, TResult> res = null;
			res = (t1, t2, t3, t4) =>
			{
				Tuple<T1, T2, T3, T4> key = Tuple.Create(t1, t2, t3, t4);
				if (!cache.ContainsKey(key))
					cache.Add(key, f(t1, t2, t3, t4, res));
				return cache[key];
			};
			return res;
		}

		private static IEnumerable<T> single<T>(T it)
		{
			yield return it;
		}

		private static IEnumerable<long> range(long first, long last, long step = 1)
		{
			for (long i = first; i <= last; i += step)
				yield return i;
		}

		private static IEnumerable<int> range(int first, int last, int step = 1)
		{
			for (int i = first; i <= last; i += step)
				yield return i;
		}

		private static T id<T>(T a)
		{
			return a;
		}

		public static T[][] Mkarr<T>(int x, int y)
		{
			var res = new T[x][];
			for (int i = 0; i < x; i++)
				res[i] = new T[y];
			return res;
		}

		public static T[][][] Mkarr<T>(int x, int y, int z)
		{
			var res = new T[x][][];
			for (int i = 0; i < x; i++)
			{
				res[i] = new T[y][];
				for (int j = 0; j < y; j++)
					res[i][j] = new T[z];
			}
			return res;
		}

		private static bool[] tf = { true, false };

#if CodeJam

		static void Main(string[] args)
		{
			if (DEBUG)
			{
				debug();
			}
			else
			{
				Initialize();
				SolveAll(solveCase);
			}
			Console.ReadKey();
		}

		private static StreamReader inf;
		private static StreamWriter outf;

		private delegate void o(string format, params object[] args);
		private static o Output;

		public static void Initialize()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("File name: ");
			string name = Console.ReadLine();
			inf = new StreamReader($"D:\\Users\\marku\\Downloads\\{name}.in");
			outf = new StreamWriter($"D:\\Users\\marku\\Downloads\\{name}.out");
			Console.ForegroundColor = ConsoleColor.White;
			Output = highlightedPrint;
			Output += outf.WriteLine;
		}

		private static void highlightedPrint(string format, params object[] args)
		{
			ConsoleColor prev = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(format, args);
			Console.ForegroundColor = prev;
		}

		public static void SolveAll(Func<int, string> calc)
		{
			int cases = int.Parse(inf.ReadLine());
			for (int _ = 1; _ <= cases; _++)
			{
				Output($"Case #{_}: {calc(_)}");
			}
			inf.Close();
			outf.Close();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Eureka!");
		}

		private static string read()
		{
			return inf.ReadLine();
		}
#endif

#if CodeForces
		private static string asString(object s)
		{
			if (s is double)
				return ((double)s).ToString("0.000000000", CultureInfo.InvariantCulture);
			return s.ToString();
		}

		public static void Main(string[] args)
		{
#if DEBUG
			Stopwatch sw = new Stopwatch();
			sw.Start();
#endif
			object o = solve();
			if (o != null)
			{
				string s;
				IEnumerable e = o as IEnumerable;
				if ((e != null) && !(o is string))
					s = string.Join(" ", e.OfType<object>().Select(asString));
				else
					s = asString(o);
				if (!string.IsNullOrEmpty(s))
					Console.WriteLine(s);
			}
#if DEBUG
			sw.Stop();
			Console.WriteLine(sw.Elapsed);
			Console.ReadKey();
#endif
		}

		private static string read()
		{
#if !DEBUG
			return Console.ReadLine();
#else
			return testInput.Dequeue();
#endif
		}
#endif
	}

	public static class ExtensionMethods
	{
		public static IEnumerable<T> Of<T>(this int n, Func<T> gen)
		{
			for (int i = 0; i < n; i++)
				yield return gen();
		}

		public static IEnumerable<T> Of<T>(this int n, Func<long, T> gen)
		{
			for (int i = 0; i < n; i++)
				yield return gen(i);
		}

		public static IEnumerable<T> Of<T>(this int n, T gen)
		{
			for (int i = 0; i < n; i++)
				yield return gen;
		}

		public static IEnumerable<TOut> Cartesian<T1, T2, TOut>(this IEnumerable<T1> first, IEnumerable<T2> second, Func<T1, T2, TOut> collector)
		{
			return first.SelectMany(f => second.Select(s => collector(f, s)));
		}

		public static IEnumerable<Tuple<T1, T2>> Cartesian<T1, T2>(this IEnumerable<T1> first, IEnumerable<T2> second)
		{
			return first.Cartesian(second, Tuple.Create);
		}

		public static IEnumerable<Tuple<T1, T2>> CartesianE<T1, T2>(this IEnumerable<T1> first, IEnumerable<T2> second)
		{
			// Calling CartesianE prevents selection of the wrong overload of Cartesian when you want a tuple of tuples to be returned
			return first.Cartesian(second);
		}

		public static IEnumerable<Tuple<T1, T2, T3>> Cartesian<T1, T2, T3>(this IEnumerable<Tuple<T1, T2>> first, IEnumerable<T3> second)
		{
			return first.Cartesian(second, (x, y) => Tuple.Create(x.Item1, x.Item2, y));
		}

		public static IEnumerable<Tuple<T1, T2, T3, T4>> Cartesian<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3>> first, IEnumerable<T4> second)
		{
			return first.Cartesian(second, (x, y) => Tuple.Create(x.Item1, x.Item2, x.Item3, y));
		}

		public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> Cartesian<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4>> first, IEnumerable<T5> second)
		{
			return first.Cartesian(second, (x, y) => Tuple.Create(x.Item1, x.Item2, x.Item3, x.Item4, y));
		}

		public static IEnumerable<IEnumerable<T>> Cartesian<T>(this IEnumerable<IEnumerable<T>> source)
		{
			IEnumerable<T>[] enumerable = source as IEnumerable<T>[] ?? source.ToArray();
			IEnumerable<IEnumerable<T>> res = enumerable.First().Select(single);
			foreach (IEnumerable<T> next in enumerable.Skip(1))
				res = res.Cartesian(next, (sofar, n) => sofar.Concat(single(n)));
			return res;
		}

		public static IEnumerable<IEnumerable<T>> Pow<T>(this IEnumerable<T> it, int num)
		{
			return Enumerable.Repeat(it, num).Cartesian();
		}

		public static IEnumerable<T> Demask<T>(this IEnumerable<Tuple<T, bool>> inp)
		{
			foreach (Tuple<T, bool> pair in inp)
				if (pair.Item2)
					yield return pair.Item1;
		}

		public static IEnumerable<IEnumerable<IEnumerable<T>>> Partition<T>(this IEnumerable<T> source, int groups)
		{
			T[] src = source as T[] ?? source.ToArray();
			foreach (int[] part in Enumerable.Range(0, groups).Pow(src.Length).Select(x => x.ToArray()))
				yield return Enumerable.Range(0, groups).Select(x => src.Where((item, idx) => part[idx] == x));
		}

		public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> it)
		{
			T[] itt = it as T[] ?? it.ToArray();
			foreach (IEnumerable<bool> conf in new[] { true, false }.Pow(itt.Length))
				yield return itt.Zip(conf, Tuple.Create).Demask();
		}

		private static IEnumerable<T> single<T>(T it)
		{
			yield return it;
		}

		private static IEnumerable<T> exceptSingle<T>(this IEnumerable<T> first, T it, IEqualityComparer<T> comp = null)
		{
			comp = comp ?? EqualityComparer<T>.Default;
			bool seen = false;
			foreach (T a in first)
				if (!seen && comp.Equals(a, it))
					seen = true;
				else
					yield return a;
		}

		public static IEnumerable<IEnumerable<T>> Permutations<T>(this IEnumerable<T> it)
		{
			T[] src = it as T[] ?? it.ToArray();
			if (src.Length < 2)
			{
				yield return src;
				yield break;
			}

			foreach (T first in src)
				foreach (IEnumerable<T> part in Permutations(src.exceptSingle(first)))
					yield return single(first).Concat(part);
		}

		public static T[][] Rho<T>(this IEnumerable<T> source, int x, int y)
		{
			T[][] res = Program.Mkarr<T>(x, y);

			int i = 0, j = 0;

			T[] src = source as T[] ?? source.ToArray();
			while (true)
			{
				foreach (T item in src)
				{
					res[i][j] = item;
					j++;
					if (j == y)
					{
						j = 0;
						i++;
						if (i == x)
							break;
					}
				}
				if (i == x)
					break;
			}

			return res;
		}

		public static T[][][] Rho<T>(this IEnumerable<T> source, int x, int y, int z)
		{
			T[][][] res = Program.Mkarr<T>(x, y, z);

			int i = 0, j = 0, k = 0;
			T[] src = source as T[] ?? source.ToArray();
			while (true)
			{
				foreach (T item in src)
				{
					res[i][j][k] = item;
					k++;
					if (k == z)
					{
						k = 0;
						j++;
						if (j == y)
						{
							j = 0;
							i++;
							if (i == x)
								break;
						}
					}
				}
				if (i == x)
					break;
			}

			return res;
		}
	}
}
