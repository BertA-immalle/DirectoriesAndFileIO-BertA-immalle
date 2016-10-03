# Analyseer

Bekijk de volledige commit-geschiedenis om te bestuderen hoe dit project tot stand gekomen is.

Probeer volgende vragen te beantwoorden:

i.v.m. MSTest:

- Welke Assert-methods worden naast `Assert.AreEqual` nog allemaal gebruikt?

> `assert.ok`, `assert.Equal`, `assert.IsTrue`, `assert.IsFalse` 

- Waarom heeft `TestDirectories` een `Initialize`- en `CleanUp`-method?

> `cleanup`-method is om andere tests hun inhoud te verwijderen
> `Initialize`-method word gebruikt om te initialiseren

- Zijn de attributen `[TestMethod]`, `[TestClass]`, ... noodzakelijk? (Test uit!)

> nee, je kan ze veranderen en dan nog werken je tests.

- Wat is de shortcut om alle tests uit te voeren in VS?

> ctrl + R, A

i.v.m. Files en Directories:

- Wat is het voordeel van `Path.Combine` i.v.m. strings aan elkaar plakken?

> deze methode is handiger

- Wordt de return-waarde van `Directory.CreateDirectory(...)` steeds opgevangen? (TIP: gebruik `CTRL-SHIFT-F`)

> nee, het word gebruikt eenmalig

- Wat is de return-waarde van `Directory.CreateDirectory(...)`?

> de testDir

- Wanneer is het nuttig om de return-waarde van `Directory.CreateDirectory(...)` op te vangen?

> als je ze meerdere keren wilt gebruiken dat in dit project niet nodig is. het word eenmalig gebruikt.


i.v.m. duidelijkheid/geschiedenis van de code:

- Lukken de testen in de commit 3ffe2c86? Waarom (niet)?

> ja, het is allemaal geldige code.

- Wat lost commit d0320b6a op?

> 

- Wat is het probleem met de files in commit 9d184949?
- Wat doet commit 9b3e4065? Maakt dit de code makkelijker leesbaar? Makkelijker uitbreidbaar?


