using System;
using System.Collections.Generic;
using System.Text;

namespace ImageToASCCIConverter
{
    /// <summary>
    /// Servicio para imprimir el logo de la comunidad en formato ascii
    /// </summary>
    public class ServiceLogoNetCode27
    {
        /// <summary>
        /// Devuele la cadena del logo
        /// </summary>
        /// <returns></returns>
        public string GetLogoASCII()
        {
            return @"MhoooooooooooooooooooooooooooooooooooyNmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmN
M/                         `+/`      :NdhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhN
M/                       .odmms      :NdhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhN
M/      `:-            .odmdy-       :Ndhhhs`-yhhhhhh.+hhh--////+hs///-.///+hhhN
M/    `:ymms`        .sdmds-  `/:`   :Ndhhhs /.ohhhhh`+hhh.+hhhhhhhhhh+`hhhhhhhN
M/  `/hmmh+`       -smmds-   `ymmh/` :Ndhhhs yy-:yhhh`+hhh./yyyyhhhhhh+`hhhhhhhN
M/ -hmmmo`       -smmdo.      `ommmh-:Ndhhhs yhh/.ohh`+hhh.-////shhhhh+`hhhhhhhN
M/  :ydmd+`   `:ymmdo.       .odmdy: :Ndhhhs yhhhs-/y`+hhh.+hhhhhhhhhh+`hhhhhhhN
M/    -sy:  `:ymmdo.        odmds-   :Nyyhhs yhhhhy/-`+hhh./yyyyyhhhhh+`hhhhhhhN
M/        `:ymmh+.          -ss-     :m/ohhy:yhhhhhho:shhh///////hhhhhs:hhhhhhhN
M/       /hmmh+`                     :NdhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhN
M/       :yh/`                       :NdhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhN
My////////++/////////////////////////sNdhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhN
MMmddddhysssyhdddhyssssyhdddhsssssyhddhhyooooooyyyyyyyysooosyyysoooooooyyyyyyymM
MMdyyyo--/++/-syo--/++/-.oyyy -++/:.:syyo :++++syyyyyy:/++:`/yyo/////.`syyyyyymM
MMdyys`-yyyyyyys`-yyyyyy-`syy :yyyys`.yy+ oyyyyyyyyyyyyyyyy`.yyyyyyy/`+yyyyyyymM
MMdyy/ oyyyyyyy+ oyyyyyy+ +yy :yyyyy: sy+ -:::+yyyyyyyyyyy:`oyyyyyy+ +yyyyyyyymM
MMdyy+ +yyyyyyy+ /yyyyyy: syy :yyyyy-`yy+ +yyyyyyyyyyyyy+.:syyyyyy+ /yyyyyyyyymM
MMdyyy-`/syso/sy-`+syys/`/yyy :ssso-`oyy+ +ssssyyyyyyy+.-osssyyyyo`:yyyyyyyyyymM
MMdyyyyo/:::/+yyyo/::::+syyyy:::://oyyyys::::::oyyyyyy:::::::syyy:/yyyyyyyyyyymM
MMdyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyymM
MMdyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyymM
MMmdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddmM" + System.Environment.NewLine;
        }

                
        /// <summary>
        /// Imprime el logo en una consola
        /// </summary>
        public void PrintLogo()
        {
            Console.WriteLine(GetLogoASCII());
            Console.ReadLine();
        }
    }
}
