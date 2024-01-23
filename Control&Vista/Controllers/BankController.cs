using Microsoft.AspNetCore.Mvc;

namespace Control_Vista.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
        public IActionResult Depositar()
        {
            return View();
        }

        public IActionResult Dispensacion() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calcular(int monto, string modo)
        {
            string resultado = "";
            if (monto != 0)
            {
                switch (modo.ToLower())
                {
                    case "modo1":
                        resultado = Dispensar1(monto);
                        break;

                    case "modo2":
                        resultado = Dispensar2(monto);
                        break;

                    case "modo3":
                        resultado = Dispensar3(monto);
                        break;

                }
            }
            else
            {
                resultado = "Ingrese un monto valido";
            }
            
            
            return RedirectToAction("Resultado", new { resultado = resultado});
        }
        public IActionResult Resultado(string resultado)
        {
            ViewBag.resultado = resultado;
            return View();
        }
        public IActionResult Consultar()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public string Dispensar1(int monto)
        {
            string resultado = "";
            int papeletas1000 = 0;
            int papeletas200 = 0;
            if (monto > 0)
            {
                if (monto % 1000 == 0 || monto % 200 == 0)
                {

                    papeletas1000 = (int)(monto / 1000);

                    if (papeletas1000 > 0)
                    {
                        monto = monto - (papeletas1000 * 1000);
                    }

                        papeletas200 = (int)(monto / 200);
                   

                    resultado = $"Se han dispensado {papeletas1000} peletas de 1000 y " +
                        $"{papeletas200} papeletas de 200";

                }
                else
                {
                    resultado = "Este cajero solo dispensa papeletas de 200 y 1000";
                }
            }

            else
            {
                resultado = "Ingrese un monto valido";
            }


            return resultado;
        }
        public string Dispensar2(int monto)
        {
            string resultado = "";
            int papeletas500 = 0;
            int papeletas100 = 0;
            if (monto > 0)
            {
                if (monto % 100 == 0 || monto % 500 == 0)
                {

                    papeletas500 = (int)(monto / 500);

                    if (papeletas500 > 0)
                    {
                        monto = monto - (papeletas500 * 500);
                    }

                    papeletas100 = (int)(monto / 100);


                    resultado = $"Se han dispensado {papeletas500} peletas de 500 y " +
                        $"{papeletas100} papeletas de 100";

                }
                else
                {
                    resultado = "Este cajero solo dispensa papeletas de 500 y 100";
                }
            }

            else
            {
                resultado = "Ingrese un monto valido";
            }


            return resultado;
        }
        public string Dispensar3(int monto)
        {
            string resultado = "s";

            return resultado;
        }
    }
}
