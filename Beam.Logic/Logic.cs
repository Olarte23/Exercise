namespace Beam.Logic
{
    public class Logic
    {
        private readonly string _txt;

        public Logic(string txt)
        {
            _txt = txt;
        }
        public String Validator()
        {
         
            if (!(_txt[0] == '%' || _txt[0] == '&' || _txt[0] == '#'))
            {
                return "La viga esta mal construida!";
            }
            
            for (int i = 1; i < _txt.Length; i++)
            {
                if (!(_txt[i].Equals('=') || _txt[i].Equals('*')))                    
                {
                    return "La viga esta mal construida!";
                }
            }
            for (int i = 1; i < _txt.Length - 1; i++)
            {
                if (_txt[i].Equals('*') && _txt[i + 1].Equals('*'))
                {
                    return "La viga esta mal construida!";
                }
                
            }
            return "Beam Acept";

        }
    }
}