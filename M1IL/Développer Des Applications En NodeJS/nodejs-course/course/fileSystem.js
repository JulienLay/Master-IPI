import fs, { readFile, readFileSync } from 'fs'

// Bloquant
const content = readFileSync('./data/poem.txt')
console.log('Poem : ', content)

// Non bloquant
readFile('./data/poem.txt', (err, content) => {
    if (err) throw err
    console.log('Poem : ', content)
})

console.log('Next operations...')