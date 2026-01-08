function afficherTableAscii() {
    // Créer un tableau pour stocker les données
    let tableauAscii = [];

    // Remplir le tableau avec les caractères ASCII et leurs codes
    for (let i = 0; i <= 127; i++) {
      let caractere = String.fromCharCode(i);
      tableauAscii.push({ Caractere: caractere, CodeAscii: i });
    }

    // Afficher le tableau avec console.table()
    console.table(tableauAscii);
}

// Fonction pour le chiffre de César avec décalage variable
function chiffreDeCesarAvecDecalage(texte, decalage) {
    let resultat = '';

    // Appeler la fonction pour afficher la table ASCII
    afficherTableAscii();

    for (let i = 0; i < texte.length; i++) {
      let charCode = texte.charCodeAt(i);

      // Vérifier si le caractère est une lettre majuscule
      if (charCode >= 65 && charCode <= 90) {
        // Appliquer le décalage aux lettres majuscules
        charCode = (charCode - 65 + decalage) % 26 + 65;
      }
      // Vérifier si le caractère est une lettre minuscule
      else if (charCode >= 97 && charCode <= 122) {
        // Appliquer le décalage aux lettres minuscules
        charCode = (charCode - 97 + decalage) % 26 + 97;
      }
      // Gérer tous les autres caractères
      else {
        charCode += decalage;
      }

      // Ajouter le caractère décodé au résultat
      resultat += String.fromCharCode(charCode);
    }

    return resultat;
}

  // Exemple d'utilisation avec décalage variable de 3
  console.log("Résultat après caesar : " + chiffreDeCesarAvecDecalage("Hello World", 3)); // Affiche "Khoor#Zruog"