<center><h1 style="font-size: 32px;">Pruebas Unitarias con Xunit</h1></center>
<center><h2 style="font-size: 20px;">Integrantes:</h2><p style="text-align: justify;">Johan Javier Triana Sanchez, Miguel Angel Vallejo Giraldo, Luisa Fernanda Tamayo Arias, Santiago Montoya Restrepo</p></center>

<center><h2 style="font-size: 20px;">🎯 Objetivo del proyecto</h2></center>

<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 10 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones. A continuación se muestra el codigo del documento</p>

```csharp
namespace Pruebas_unitarias.Tests
{
    public class ProgramShould
    {
        private readonly StringOperations _stringOperations;
        private readonly ILogger<StringOperations> _logger;

        public ProgramShould()
        {
            _logger = new NullLogger<StringOperations>();
            _stringOperations = new StringOperations(_logger);
        }
```
<center><h2 style="font-size: 20px;">Función 1: ConcatenateStrings </h2></center>
<p style="text-align: justify;">Esta función es una prueba unitaria que se asegura de que la operación de concatenación de cadenas funcione correctamente. La prueba verifica si, al concatenar dos cadenas utilizando el método ConcatenateStrings de la clase StringOperations, se obtiene el resultado esperado.
Se espera que al concatenar las cadenas "Hola" y "Mundo", el resultado sea la cadena "Hola Mundo". Si la prueba pasa satisfactoriamente, significa que la función ConcatenateStrings está funcionando correctamente.
</p>

```csharp
        [Fact]
        public void ConcatenateStringsCorrectly()
        {
            string result = _stringOperations.ConcatenateStrings("Hola", "Mundo");
            Assert.Equal("Hola Mundo", result);
        }
```
<center><h2 style="font-size: 20px;">Función 2: ReverseString </h2></center>
<p style="text-align: justify;">La función ReverseString es otra prueba unitaria diseñada para verificar si la operación de reversión de una cadena funciona correctamente. Esta prueba se asegura de que, al pasar una cadena al método ReverseString de la clase StringOperations, la cadena se invierte correctamente y se obtiene el resultado esperado.
Se espera que al pasar la cadena "Hola" al método ReverseString, el resultado sea la cadena invertida "aloH". Si la prueba pasa satisfactoriamente, significa que la función ReverseString está funcionando correctamente.</p>

```csharp
        [Fact]
        public void ReverseStringCorrectly()
        {
            string result = _stringOperations.ReverseString("Hola");
            Assert.Equal("aloH", result);
        }
```
<center><h2 style="font-size: 20px;">Función 3: GetStringLength </h2></center>
<p style="text-align: justify;">La función GetStringLength es una prueba unitaria diseñada para verificar si la operación de obtención de la longitud de una cadena funciona correctamente. Esta prueba se asegura de que, al pasar una cadena al método GetStringLength de la clase StringOperations, se devuelve la longitud de la cadena de manera precisa.
Se espera que al pasar la cadena "Hola" al método GetStringLength, se devuelva el valor 4, que es la longitud de la cadena. Si la prueba pasa satisfactoriamente, significa que la función GetStringLength está funcionando correctamente.</p>

```csharp
        [Fact]
        public void GetStringLengthCorrectly()
        {
            int length = _stringOperations.GetStringLength("Hola");
            Assert.Equal(4, length);
        }
```
<center><h2 style="font-size: 20px;">Función 4: RemoveWhitespace </h2></center>
<p style="text-align: justify;">La función RemoveWhitespace es una prueba unitaria diseñada para verificar si la operación de eliminar los espacios en blanco de una cadena funciona correctamente. Esta prueba se asegura de que, al pasar una cadena con espacios en blanco al método RemoveWhitespace de la clase StringOperations, se devuelva la cadena sin los espacios en blanco.
Se espera que al pasar la cadena "H o l a" al método RemoveWhitespace, se devuelva la cadena "Hola" sin espacios en blanco. Si la prueba pasa satisfactoriamente, significa que la función RemoveWhitespace está funcionando correctamente.</p>

```csharp
        [Fact]
        public void RemoveWhitespaceCorrectly()
        {
            string result = _stringOperations.RemoveWhitespace("H o l a");
            Assert.Equal("Hola", result);
        }
```
<center><h2 style="font-size: 20px;">Función 5: TruncateString </h2></center>
<p style="text-align: justify;">La función TruncateString es una prueba unitaria diseñada para verificar si la operación de truncar una cadena a una longitud específica funciona correctamente. Esta prueba se asegura de que, al pasar una cadena y una longitud al método TruncateString de la clase StringOperations, se devuelva una subcadena truncada con la longitud especificada.
Se espera que al pasar la cadena "Hola Mundo" y una longitud de 4 al método TruncateString, se devuelva la subcadena "Hola". Si la prueba pasa satisfactoriamente, significa que la función TruncateString está funcionando correctamente.</p>

```csharp
        [Fact]
        public void TruncateStringCorrectly()
        {
            string result = _stringOperations.TruncateString("Hola Mundo", 4);
            Assert.Equal("Hola", result);
        }
```
<center><h2 style="font-size: 20px;">Función 6: IsPalindrome </h2></center>
<p style="text-align: justify;">La función IsPalindrome es una prueba unitaria diseñada para verificar si una cadena es un palíndromo correctamente. Un palíndromo es una palabra o frase que se lee igual de izquierda a derecha que de derecha a izquierda.
Se espera que al pasar la cadena "anilina" al método IsPalindrome, el resultado sea verdadero (true) ya que "anilina" es un palíndromo. Si la prueba pasa satisfactoriamente, significa que la función IsPalindrome está funcionando correctamente.</p>

```csharp
        [Fact]
        public void IsPalindromeCorrectly()
        {
            bool isPalindrome = _stringOperations.IsPalindrome("anilina");
            Assert.True(isPalindrome);
        }
```
<center><h2 style="font-size: 20px;">Función 7: CountOccurrences </h2></center>
<p style="text-align: justify;">La función CountOccurrences es una prueba unitaria diseñada para verificar si la operación de contar las ocurrencias de un carácter específico en una cadena funciona correctamente. Esta prueba se asegura de que, al pasar una cadena y un carácter al método CountOccurrences de la clase StringOperations, se devuelva el número correcto de ocurrencias del carácter en la cadena.
Se espera que al pasar la cadena "Hola Mundo" y el carácter 'o' al método CountOccurrences, el resultado sea 2, ya que el carácter 'o' aparece dos veces en la cadena. Si la prueba pasa satisfactoriamente, significa que la función CountOccurrences está funcionando correctamente.</p>

```csharp
        [Fact]
        public void CountOccurrencesCorrectly()
        {
            int count = _stringOperations.CountOccurrences("Hola Mundo", 'o');
            Assert.Equal(2, count);
        }
```
<center><h2 style="font-size: 20px;">Función 8: Pluralize </h2></center>
<p style="text-align: justify;">Esta prueba unitaria asegura que el método Pluralize de la clase de operaciones de cadena transforma correctamente una palabra del singular al plural. En este caso específico, verifica que al pasar la palabra "manzana" como argumento al método Pluralize, el resultado devuelto sea "manzanas", que es la forma plural correcta en español.</p>

```csharp
        [Fact]
        public void PluralizeCorrectly()
        {
            string result = _stringOperations.Pluralize("manzana");
            Assert.Equal("manzanas", result);
        }
```
<center><h2 style="font-size: 20px;">Función 9: QuantintyInWords </h2></center>
<p style="text-align: justify;">Esta prueba unitaria verifica que el método QuantityInWords funcione adecuadamente al convertir una cantidad numérica y una palabra en su representación textual correcta. En este caso, se asegura de que al proporcionar la palabra "manzana" y el número 5, el método retorne la cadena "cinco manzanas".</p>

```csharp
        [Fact]
        public void QuantityInWordsCorrectly()
        {
            string result = _stringOperations.QuantintyInWords("manzana", 5);
            Assert.Equal("cinco manzanas", result);
        }
```
<center><h2 style="font-size: 20px;">Función 10: FromRomanToNumber </h2></center>
<p style="text-align: justify;">Esta prueba unitaria confirma que el método FromRomanToNumber convierte correctamente números romanos a su equivalente numérico. En este ejemplo específico, se verifica que al ingresar el número romano "V", el método retorne el número 5 para garantizar su efectvidad.</p>

```csharp
        [Fact]
        public void FromRomanToNumberCorrectly()
        {
            int number = _stringOperations.FromRomanToNumber("V");
            Assert.Equal(5, number);
        }
    }
}
