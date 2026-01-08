// Module File System
const fs = require('fs');
const csv = require('csv-parser');

// TP1
fs.readFile('data/quiz.json', (err, data) => {
    if (err) console.log(err);

    let dataStr = data.toString();
    let dataJSON = JSON.parse(dataStr);
    // Affichage des données
    console.log(dataJSON['quiz'].maths.q2.answer);
    console.log(dataJSON['quiz'].sport.q1.options[2]);
    console.log(dataJSON['quiz'].sport.q1.question);
    console.log(dataJSON['quiz'].maths.q2.question);
    console.log(dataJSON['quiz'].sport.q1.options[dataJSON['quiz'].sport.q1.options.length - 1]);
    console.log(dataJSON['quiz'].maths.q2.options.length);
})

// TP2
fs.readFile('data/weather.json', (err, data) => {
    if (err) console.log(err);

    let dataStr = data.toString();
    let dataJSON = JSON.parse(dataStr);
    // Affichage des données
    console.log(dataJSON);

    // 1. Modifier la valeur de "sea_level" en 1156.
    dataJSON.main.sea_level = 1156;

    // 2. Supprimer la propriété "description" de "weather".
    delete dataJSON.weather[0].description;

    // 3. Trouver à quelle date correspond "sunrise" puis enlever 15 minutes.
    const sunriseTimestamp = dataJSON.sys.sunrise * 1000; // Convertir en millisecondes
    console.log("Sunrise (avant modification) :", new Date(sunriseTimestamp).toLocaleString());

    const nouvelleDateSunrise = new Date(sunriseTimestamp - 15 * 60 * 1000); // Retirer 15 minutes
    console.log("Nouvelle date sunrise après retrait de 15 minutes :", nouvelleDateSunrise.toLocaleString());

    dataJSON.sys.sunrise = Math.floor(nouvelleDateSunrise.getTime() / 1000); // Convertir en secondes

    // 4. Ajouter dans "main" la température en Celsius.
    const temperatureCelsius = parseFloat((dataJSON.main.temp - 273.15).toFixed(2));
    dataJSON.main.temperatureCelsius = temperatureCelsius;

    // BONUS : Calculer dans le format hh:mm:ss, la durée de la journée.
    const sunriseDate = new Date(dataJSON.sys.sunrise * 1000);
    const sunsetDate = new Date(dataJSON.sys.sunset * 1000);
    const dureeJournee = sunsetDate.getTime() - sunriseDate.getTime();

    const heures = Math.floor(dureeJournee / 3600000);
    const minutes = Math.floor((dureeJournee % 3600000) / 60000);
    const secondes = Math.floor((dureeJournee % 60000) / 1000);

    const formatDureeJournee = `${heures}:${minutes}:${secondes}`;
    console.log("Durée de la journée avec le bon format (hh:mm:ss) :", formatDureeJournee);

    // Sauvegarder les données modifiées dans un nouveau fichier JSON
    const donneesModifiees = JSON.stringify(dataJSON, null, 2);
    fs.writeFileSync('data/weatherModified.json', donneesModifiees);
})

// TP3
const products = [];

const csvFilePath = 'data/products.csv';
const jsonFilePath = 'data/products.json';

fs.createReadStream(csvFilePath)
  .pipe(csv())
  .on('data', (row) => {
    // Convertir les valeurs de price et rate en nombres
    row.price = parseFloat(row.price);
    row.rate = parseFloat(row.rate);

    products.push(row);
  })
  .on('end', () => {
    // Enregistrez le tableau d'objets JSON dans un fichier
    fs.writeFileSync(jsonFilePath, JSON.stringify({ products }, null, 2));

    console.log(`La conversion de products.csv en products.json est terminée.`);
  });