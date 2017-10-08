using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mainFoP

{
class FoP
{
public string fop;
static string ping;
static int fps;
public int fpp;

static void Main(string[] args){


}
public void getFpp(){
	 fpp = fps/ping;
}
private static void getFop(){
fop = fpp * 10;
return fop;
}

	}

		}