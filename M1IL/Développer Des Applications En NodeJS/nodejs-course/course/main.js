const isEven = (n) => {
    return n % 2 == 0
}
console.log(isEven(2))
console.log(isEven(3))
console.log(typeof isEven)

let productIds = [4, 5, 6, 7]
let newProductIds = productIds.map((elem, key) => key)
console.log(newProductIds)

let elements = [1, 36, 9, 25]
let squareRoots = elements.map(Math.sqrt)
console.log(squareRoots)