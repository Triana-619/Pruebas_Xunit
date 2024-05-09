<center><h1 style="font-size: 32px;">Pruebas Unitarias con Xunit</h1></center>

<center><h2 style="font-size: 20px;">🎯 Objetivo del proyecto</h2></center>

<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

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
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void GetStringLengthCorrectly()
        {
            int length = _stringOperations.GetStringLength("Hola");
            Assert.Equal(4, length);
        }
```
<center><h2 style="font-size: 20px;">Función 4: RemoveWhitespace </h2></center>
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void RemoveWhitespaceCorrectly()
        {
            string result = _stringOperations.RemoveWhitespace("H o l a");
            Assert.Equal("Hola", result);
        }
```
<center><h2 style="font-size: 20px;">Función 5: TruncateString </h2></center>
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void TruncateStringCorrectly()
        {
            string result = _stringOperations.TruncateString("Hola Mundo", 4);
            Assert.Equal("Hola", result);
        }
```
<center><h2 style="font-size: 20px;">Función 6: IsPalindrome </h2></center>
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void IsPalindromeCorrectly()
        {
            bool isPalindrome = _stringOperations.IsPalindrome("anilina");
            Assert.True(isPalindrome);
        }
```
<center><h2 style="font-size: 20px;">Función 7: CountOccurrences </h2></center>
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void CountOccurrencesCorrectly()
        {
            int count = _stringOperations.CountOccurrences("Hola Mundo", 'o');
            Assert.Equal(2, count);
        }
```
<center><h2 style="font-size: 20px;">Función 8: Pluralize </h2></center>
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void PluralizeCorrectly()
        {
            string result = _stringOperations.Pluralize("manzana");
            Assert.Equal("manzanas", result);
        }
```
<center><h2 style="font-size: 20px;">Función 9: QuantintyInWords </h2></center>
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void QuantityInWordsCorrectly()
        {
            string result = _stringOperations.QuantintyInWords("manzana", 5);
            Assert.Equal("cinco manzanas", result);
        }
```
<center><h2 style="font-size: 20px;">Función 10: FromRomanToNumber </h2></center>
<p style="text-align: justify;">El proyecto se realizó con el objetivo de ejecutar pruebas unitarias en Microsoft Visual Studio usando el lenguaje C# e implementando la herramienta xUnit. Además, se hicieron 11 funciones que interactúan con cadenas de texto para proporcionar diferentes soluciones.</p>

```csharp
        [Fact]
        public void FromRomanToNumberCorrectly()
        {
            int number = _stringOperations.FromRomanToNumber("V");
            Assert.Equal(5, number);
        }
    }
}
