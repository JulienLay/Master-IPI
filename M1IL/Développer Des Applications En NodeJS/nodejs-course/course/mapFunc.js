let marks = [6, 18, 15.5, 11]

function mapFunc(arr, callback) {
    let result = []
    for(const element of arr) {
        result.push(callback(element))
    }
    return result
}

// Ajout d'un point bonus pour chaque note
let marksWithBonus = mapFunc(marks, element => { return element + 1 })
console.table(marksWithBonus)