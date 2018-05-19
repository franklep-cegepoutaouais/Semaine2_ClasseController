using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FormulaireController : Controller
    {
        /// <summary>
        /// Voir le formulaire.
        /// </summary>
        /// [Il manque aussi quelque chose ici...]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Procède à l'inscription suite au clic du bouton 'Envoyer' du formulaire.
        /// </summary>
        /// <param name="donneesFormulaire">Données provenant du formulaire.</param>
        /// <returns>Résultat d'action (Code HTTP).</returns>
        /// [Il manque aussi quelque chose ici...]
        public ActionResult Inscrire(AjouterEmploye donneesFormulaire)
        {
            throw new NotImplementedException();

            // Voici les étapes à faire.
            // 1. Vérifier les données.
            // 1.1 Nom vide => lancer une exception.
            // 1.2 Prénom vide => lancer une exception.
            // 1.3 Email vide => lancer une exception.

            // 2. Écrire dans la console pour y voir les informations.

            // 3. Retourner à l'écran principal et y dire un beau bonjour!
        }
    }
}