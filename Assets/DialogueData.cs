using System;
using System.Collections.Generic;

internal class DialogueData
{
    internal static List<string> GetDialogueData(int id)
    {
       return dialogueData[id];
    }

    private static List<List<string>> dialogueData = new List<List<string>>()
    {
        new List<string>()
        {
            "Hello, Director\nI am the first dialogue box",
            "I am here to help you",
            "I will show you the way",
            "The Jedi are taking over",
        },
        new List<string>()
        {
            "Une affaire de plagiat massif vient d'être découverte parmi nos étudiants. " +
            "Cette situation nuit gravement à notre réputation.\n",
            "Nous devons agir rapidement pour rétablir l'intégrité académique et rassurer notre communauté."
        },
        new List<string>()
        {
            "Une opportunité exeptionnelle se présente à l'IUT." +
            "Un financement CPER de 4 millions a été accordé à l'IUT pour la rénovations de nos infrastructures.",
            "A vous de décider la meilleur manière d'utiliser ces fonds !"
        },
        new List<string>()
        {
            "Une vague de froid sans précédent s'abat sur la région." +
            " Nos installations sont mises à rude épreuve, et les coûts de chauffage explosent. ",
            "Nous devons trouver une solution pour maintenir nos bâtiments à une température acceptable sans mettre en péril nos finances."
        },
        new List<string>()
        {
            "Un de nos enseignants vient de remporter un prix pour son approche pédagogique innovante. " +
            "C'est une formidable reconnaissance qui va améliorer notre taux de réussite et notre satisfaction ",
            "étudiante. Célébrons cette victoire ensemble !"
        },
        new List<string>()
        {
            "Nous venons de recevoir un don généreux d'un ancien élève/de notre partenaire industriel. " +
            "Cette contribution financière nous donne les moyens de poursuivre nos projets ambitieux et",
            "d'améliorer la qualité de notre enseignement. Quelle excellente nouvelle !"
        },
        new List<string>()
        {
            "Un groupe d'étudiants a organisé une manifestation pour protester contre la hausse des frais de scolarité. " +
            "Ils demandent une réduction immédiate pour rendre l'éducation plus accessible. ",
            "Nous devons trouver un compromis pour apaiser les tensions et garantir l'accès à l'enseignement supérieur pour tous."
        },
        new List<string>()
        {
            "Une panne majeure de notre système informatique vient de paralyser l'ensemble de l'IUT. " +
            "Le retour à la normale va nécessiter des investissements significatifs. ",
            "La situation est critique, mais nous surmonterons cet obstacle."
        },
        new List<string>()
        {
            "Le gouvernement vient d'annoncer une réforme de l'enseignement supérieur qui affecte directement notre fonctionnement. ",
            "Nous devons nous adapter rapidement à ces nouvelles directives pour continuer à offrir un enseignement de qualité."
        },
        new List<string>()
        {
            "Il semble que certains étudiants aient décidé de démonter le mobilier pour le fun. " +
            "C'est une dépense inattendue et une baisse de satisfaction à gérer. ",
            "C’est vraiment pas bien !"
        },
        new List<string>()
        {
            "Une pandémie mondiale frappe, obligeant l'ensemble de l'établissement à s'adapter à un enseignement à distance. " +
            "C'est un défi sans précédent pour notre taux de réussite",
            "et notre santé financière. Ensemble, nous trouverons des solutions pour continuer à éduquer nos étudiants dans les meilleures conditions."
        },
        //11
        new List<string>()
        {
            "Félicitations ! Après une réflexion minutieuse..." +
            " le conseil d'administration et moi-même avons décidé de vous confier la direction de notre institut. ",
            "Vous êtes désormais le directeur de l'IUT pour les cinq prochaines années !"
        },
        //12
        new List<string>()
        {
            "Félicitations !\n" +
            "Vous avez maintenant achevé votre mandat de directeur de l'IUT.  ",
            "Votre score global reflète les efforts investis dans la gestion financière, l'amélioration de la satisfaction et le maintien d'un taux de réussite élevé parmi les étudiants."
        }

    };
}