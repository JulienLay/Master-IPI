const readline = require('readline');
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

const askFirstName = () => {
  return new Promise(resolve => {
    rl.question('Quel est ton prénom ? ', resolve);
  });
};

const askLastName = () => {
  return new Promise(resolve => {
    rl.question('Quel est ton nom ? ', resolve);
  });
};

const askAge = () => {
  return new Promise(resolve => {
    rl.question('Quel âge as-tu ? ', resolve);
  });
};

const askCountry = () => {
  return new Promise(resolve => {
    rl.question('Dans quel pays vis-tu ? ', resolve);
  });
};

const main = () => {
  askFirstName()
    .then(firstName => {
      console.log(`Ton prénom est ${firstName}`);
    })
    .then(() => askLastName())
    .then(lastName => {
      console.log(`Ton nom est ${lastName}`);
    })
    .then(() => askAge())
    .then(age => {
      console.log(`Tu as ${age} ans`);
    })
    .then(() => askCountry())
    .then(country => {
      console.log(`Tu vis dans le pays : ${country}`);
      rl.close();
    })
    .catch(error => {
      console.error('Une erreur s\'est produite :', error);
      rl.close();
    });
};

main();
