using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    public class rawdata
    {
		public int agebracket { get; set; }
		public int backupnotes { get; set; }
		public string contractedfromwhichpatientsuspected { get; set; }
		public string currentstatus { get; set; }
		public DateTime dateannounced { get; set; }
		public string detectedcity { get; set; }
		public string detecteddistrict { get; set; }
		public string detectedstate { get; set; }
		public string estimatedonsetdate { get; set; }
		public string gender { get; set; }
		public string nationality { get; set; }
		public string notes { get; set; }
		public int numcases { get; set; }
		public int patientnumber { get; set; }
		public string source1 { get; set; }
		public string source2 { get; set; }
		public string source3 { get; set; }
		public string statecode { get; set; }
		public string statepatientnumber { get; set; }
		public DateTime statuschangedate { get; set; }
		public string typeoftransmission { get; set; }
	}
	public class root
    {
		public List<rawdata>rawdata { get; set; }
    }
}
