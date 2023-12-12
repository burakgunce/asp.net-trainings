//veri tipleri

// dynamic type
var degisken = 'hello word';
console.log(degisken);
degisken = 25;
console.log(degisken);
degisken = true;
console.log(degisken);
degisken = 'again hello';
console.log(degisken);

let degisken1 = 'degısken tanımlamak ıcın kullanılan dıger key'
//var ıle farkı bellekte kalma suresı
console.log(degisken1);
degisken1 = 'yenı deger';
console.error(degisken1);

const sabit = 'constant variable';
console.warn(sabit);
sabit = 'degısıklık yapmayı dene';
console.info(sabit);
//constant bir degere baska atama yapamazsın

//primitive veri tipleri
var str = 'string';
var number = 61;
var isValid = true;
var empty = null;
var isNotNumeric = NaN;
var undefined = undefined;
var myVar; // default olarak undefıned degerını alır

//object
var myObject = {
    firstName = 'john',
    lastName = 'doe',
    age = 25,
    isDeveloper = true
};
console.log(myObject);

//property den deger okuma
console.log(myObject["age"]);
console.log(myObject.firstName + ' ' + myObject.lastName);

//yenı bır property ekleme
myObject.country = 'Türkiye';
console.log(myObject);

//property silmek
delete myObject.isDeveloper;
confirm.log(myObject);

//property degerını degıstırme
myObject.firstName = 'jane';
console.log(myObject.firstName + ' ' + myObject.lastName);

//dizi kavramı
var myArray = ['john', 'Jeyn', 23, 47, true, false, null, NaN, undefined];
console.log(myArray);

//ındex numarasınas gore deger okuma
console.log(myArray[0]);
console.log(myArray[5]);
console.log(myArray[25]);

//deger degıstırme
myArray[0] = 'jjjj';
console.log(myArray[0]);
myArray[0] = 15;
console.log(myArray[0]);


//yenı eleman ekleme

//en sona eleman ekleme
myArray.push('hello');
console.log(myArray);

//en basa eleman ekleme
myArray.unshift('birinci eleman');
console.log(myArray);

//eleman cıkarma

//en sondakı elemanı dızıdencıkarma
myArray.pop();
console.log(myArray);

//en bastakı elemanı dızıden cıkarma
myArray.shift();
console.log(myArray);

//bellı bır konumdan baslayıp bellı sayıdakı elemanı dızıden cıkarma
myArray.splice(3, 2);
console.log(myArray);

//matematıksel operator
//toplama
var sum = 25 + 12;
console.log(sum);
//cıkarma carpma bolme mod alma aynı
//üs alma
var pow = 2 ** 3;

//matematıksel kısayoller
var number = 4;
number += 4; //- * / da da gecerlı
number++;

//karsılastırma operatorlerı c# ile aynı
var number1 = 10;
var number2 = 7;
var condition = number1 > number2;
console.log(condition);

// != !==   iki eşittir oldugunda tipi de karsılastırıyo '23' ve 23

