namespace Beam.Logic
{
    public class Logic
    {
        private readonly string _txt;

        public Logic(string txt)
        {
            _txt = txt;
        }
        public bool Validator()
        {
         
            if (!(_txt[0] == '%' || _txt[0] == '&' || _txt[0] == '#'))
            {
                throw new Exception("La viga esta mal construida!");
            }
            
            for (int i = 1; i < _txt.Length - 1; i++)
            {
                if (!(_txt[i].Equals('=') || _txt[i].Equals('*')))                    
                {
                    throw new Exception("La viga esta mal construida!");
                }
            }
            for (int i = 1; i < _txt.Length - 1; i++)
            {
                if (_txt[i].Equals('*') && _txt[i + 1].Equals('*'))
                {
                    throw new Exception("La viga esta mal construida!");
                }
                
            }
            return true;

        }
    }
}