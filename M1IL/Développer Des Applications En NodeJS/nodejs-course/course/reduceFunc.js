let marks = [6, 18, 15.5, 11];

function reduceFunc(arr, callback) {
  let accumulator = 0;

  for (let i = 0 ; i < arr.length; i++) {
    accumulator = callback(accumulator, arr[i]);
  }

  return accumulator;
}

// Additionner toutes les notes
let totalMarks = reduceFunc(marks, (accumulator, element) => accumulator + element);
console.log(totalMarks);