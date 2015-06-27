using System;
using System.Collections;
//using System.Linq;
using System.Text;

namespace Fred68.Tools.Utilita
	{
	 class TokenString
		{
		string t,s;
		// Costruttori (il testo e` passato per reference, per velocizzare)
		public TokenString()											
			{
			t = "";
			s = "";
			}
		public TokenString(ref string testo, string separatori)
			{
			t = testo;
			s = separatori;
			}
		// Impostazione
		public void Set(ref string testo, string separatori)				
			{
			t = testo;
			s = separatori;
			}
		public void SetText(ref string testo)
			{
			t = testo;
			}
		public void SetSeparator(string separatori)
			{
			s = separatori;
			}
		// Enumeratori
		public IEnumerator GetEnumerator()
			{
			StringBuilder sout = new StringBuilder();
			sout.Clear();
			foreach(char c in t)
				{
				if(s.Contains(c.ToString()))
					{
					if( ((sout.ToString()).Trim()).Length > 0)
						{
						yield return sout.ToString().Trim();
						sout.Clear();
						}
					}
				else
					{
					sout.Append(c);
					}
				}
			if (((sout.ToString()).Trim()).Length > 0)
				{
				yield return sout.ToString().Trim();
				sout.Clear();
				}
			yield break;
			}
		public IEnumerable Reset()
			{
			t = "";
			s = "";
			yield break;
			}
	
		}
	}
