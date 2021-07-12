using System.Collections.Generic;
using System.Xml.Serialization;

namespace ParseWordDocument
{
	[XmlRoot(ElementName = "pStyle", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class PStyle
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Val;
	}

	[XmlRoot(ElementName = "spacing", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Spacing
	{

		[XmlAttribute(AttributeName = "after", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int After;

		[XmlAttribute(AttributeName = "line", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Line;

		[XmlAttribute(AttributeName = "lineRule", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string LineRule;
	}

	[XmlRoot(ElementName = "jc", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Jc
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Val;
	}

	[XmlRoot(ElementName = "rFonts", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class RFonts
	{

		[XmlAttribute(AttributeName = "ascii", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Ascii;

		[XmlAttribute(AttributeName = "hAnsi", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string HAnsi;

		[XmlAttribute(AttributeName = "cs", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Cs;
	}

	[XmlRoot(ElementName = "sz", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Sz
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Val;
	}

	[XmlRoot(ElementName = "szCs", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class SzCs
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Val;
	}

	[XmlRoot(ElementName = "rPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class RPr
	{

		[XmlElement(ElementName = "b", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public B B;

		[XmlElement(ElementName = "sz", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Sz Sz;

		[XmlElement(ElementName = "szCs", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public SzCs SzCs;

		[XmlElement(ElementName = "bdr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Bdr Bdr;

		[XmlElement(ElementName = "rStyle", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public RStyle RStyle;

		[XmlElement(ElementName = "rFonts", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public RFonts RFonts;

		[XmlElement(ElementName = "bCs", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public BCs BCs;

		[XmlElement(ElementName = "color", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Color Color;

		[XmlElement(ElementName = "shd", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Shd Shd;

		[XmlElement(ElementName = "lang", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Lang Lang;
	}

	[XmlRoot(ElementName = "pPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class PPr
	{

		[XmlElement(ElementName = "pStyle", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public PStyle PStyle;

		[XmlElement(ElementName = "spacing", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Spacing Spacing;

		[XmlElement(ElementName = "jc", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Jc Jc;

		[XmlElement(ElementName = "rPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public RPr RPr;

		[XmlElement(ElementName = "numPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public NumPr NumPr;

		[XmlElement(ElementName = "tabs", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Tabs Tabs;

		[XmlElement(ElementName = "ind", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Ind Ind;
	}

	[XmlRoot(ElementName = "p", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class P
	{

		[XmlElement(ElementName = "r", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public List<R> R;

		[XmlAttribute(AttributeName = "rsidR", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public double RsidR;

		[XmlAttribute(AttributeName = "rsidP", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int RsidP;

		[XmlAttribute(AttributeName = "rsidRDefault", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string RsidRDefault;

		[XmlText]
		public string Text;

		[XmlElement(ElementName = "pPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public PPr PPr;

		[XmlAttribute(AttributeName = "rsidRPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public double RsidRPr;

		[XmlElement(ElementName = "proofErr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public List<ProofErr> ProofErr;

		[XmlElement(ElementName = "bookmarkStart", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public BookmarkStart BookmarkStart;

		[XmlElement(ElementName = "bookmarkEnd", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public BookmarkEnd BookmarkEnd;
	}

	[XmlRoot(ElementName = "r", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class R
	{

		[XmlElement(ElementName = "t", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public T T;

		[XmlAttribute(AttributeName = "rsidRPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public double RsidRPr;

		[XmlAttribute(AttributeName = "rsidR", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string RsidR;

		[XmlElement(ElementName = "rPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public RPr RPr;

		[XmlText]
		public string Text;

		[XmlElement(ElementName = "tab", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public object Tab;

		[XmlElement(ElementName = "lastRenderedPageBreak", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public object LastRenderedPageBreak;

		[XmlElement(ElementName = "br", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public object Br;
	}

	[XmlRoot(ElementName = "ilvl", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Ilvl
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Val;
	}

	[XmlRoot(ElementName = "numId", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class NumId
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Val;
	}

	[XmlRoot(ElementName = "numPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class NumPr
	{

		[XmlElement(ElementName = "ilvl", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Ilvl Ilvl;

		[XmlElement(ElementName = "numId", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public NumId NumId;
	}

	[XmlRoot(ElementName = "tab", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Tab
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Val;

		[XmlAttribute(AttributeName = "pos", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Pos;
	}

	[XmlRoot(ElementName = "tabs", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Tabs
	{

		[XmlElement(ElementName = "tab", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Tab Tab;
	}

	[XmlRoot(ElementName = "ind", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Ind
	{

		[XmlAttribute(AttributeName = "left", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Left;

		[XmlAttribute(AttributeName = "firstLine", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int FirstLine;

		[XmlAttribute(AttributeName = "hanging", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Hanging;
	}

	[XmlRoot(ElementName = "t", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class T
	{

		[XmlAttribute(AttributeName = "space", Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string Space;

		[XmlText]
		public string Text;
	}

	[XmlRoot(ElementName = "lang", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Lang
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Val;
	}

	[XmlRoot(ElementName = "proofErr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class ProofErr
	{

		[XmlAttribute(AttributeName = "type", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Type;
	}

	[XmlRoot(ElementName = "shd", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Shd
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Val;

		[XmlAttribute(AttributeName = "color", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Color;

		[XmlAttribute(AttributeName = "fill", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Fill;
	}

	[XmlRoot(ElementName = "bdr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Bdr
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Val;

		[XmlAttribute(AttributeName = "color", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Color;

		[XmlAttribute(AttributeName = "sz", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Sz;

		[XmlAttribute(AttributeName = "space", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Space;

		[XmlAttribute(AttributeName = "frame", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Frame;
	}

	[XmlRoot(ElementName = "color", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Color
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Val;
	}

	[XmlRoot(ElementName = "rStyle", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class RStyle
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Val;
	}

	[XmlRoot(ElementName = "b", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class B
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Val;
	}

	[XmlRoot(ElementName = "bCs", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class BCs
	{

		[XmlAttribute(AttributeName = "val", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Val;
	}

	[XmlRoot(ElementName = "bookmarkStart", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class BookmarkStart
	{

		[XmlAttribute(AttributeName = "name", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string Name;

		[XmlAttribute(AttributeName = "id", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Id;
	}

	[XmlRoot(ElementName = "bookmarkEnd", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class BookmarkEnd
	{

		[XmlAttribute(AttributeName = "id", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Id;
	}

	[XmlRoot(ElementName = "pgSz", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class PgSz
	{

		[XmlAttribute(AttributeName = "w", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int W;

		[XmlAttribute(AttributeName = "h", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int H;
	}

	[XmlRoot(ElementName = "pgMar", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class PgMar
	{

		[XmlAttribute(AttributeName = "top", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Top;

		[XmlAttribute(AttributeName = "right", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Right;

		[XmlAttribute(AttributeName = "bottom", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Bottom;

		[XmlAttribute(AttributeName = "left", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Left;

		[XmlAttribute(AttributeName = "header", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Header;

		[XmlAttribute(AttributeName = "footer", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Footer;

		[XmlAttribute(AttributeName = "gutter", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Gutter;
	}

	[XmlRoot(ElementName = "cols", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Cols
	{

		[XmlAttribute(AttributeName = "space", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int Space;
	}

	[XmlRoot(ElementName = "docGrid", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class DocGrid
	{

		[XmlAttribute(AttributeName = "linePitch", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public int LinePitch;
	}

	[XmlRoot(ElementName = "sectPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class SectPr
	{

		[XmlElement(ElementName = "pgSz", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public PgSz PgSz;

		[XmlElement(ElementName = "pgMar", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public PgMar PgMar;

		[XmlElement(ElementName = "cols", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public Cols Cols;

		[XmlElement(ElementName = "docGrid", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public DocGrid DocGrid;

		[XmlAttribute(AttributeName = "rsidRPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string RsidRPr;

		[XmlAttribute(AttributeName = "rsidR", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string RsidR;

		[XmlAttribute(AttributeName = "rsidSect", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public string RsidSect;
	}

	[XmlRoot(ElementName = "body", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	public class Body
	{

		[XmlElement(ElementName = "p", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public List<P> P;

		[XmlElement(ElementName = "sectPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
		public SectPr SectPr;

		[XmlAttribute(AttributeName = "w", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string W;

		[XmlText]
		public string Text;
	}
}