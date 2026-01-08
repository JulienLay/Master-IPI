let marks = [6, 18, 15.5, 11];

function filterFunc(arr, callback) {
  let result = [];
  for (const element of arr) {
    if (callback(element)) {
      result.push(element);
    }
  }
  return result;
}

// Filtrer les notes supérieures à la moyenne
let marksAboveAvg = filterFunc(marks, element => element >= 10);
console.table(marksAboveAvg);