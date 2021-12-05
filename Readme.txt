Autor: Tymoteusz Bartnik 305852

Klawiszologia:
Żadne klawisze nie są potrzebne do poprawnego działania programu, jedynie myszka i naciskania odpowiednich przycisków w aplikacji.

Przyciski UCR oraz GCR nie są zaimplementowane. Niestety nie wiedziałem do końca jak ma przebiegać wyznaczanie krzywych (tak samo 0% cofnięcia (przetłumaczone na  0% black) oraz 100% cofnięcia (100% black) (nie wiem czy to dobre tłumaczenie ale tak znalazłem w literaturze w internecie). 

Podczas uruchamiania programu / ładowania nowego obrazka może wystąpić InvalidParameterException, którego nie udało mi się w pełni rozwiązać. Występuje on sporadycznie i jest spowodowany paralelizacją operacji na obrazku w celu zwiększenia wydajności.

Przyjąłem, że kolory z CMYK są definiowane jak double pomiędzy 0 - 1 (z dokładnością do 0.01). Tak samo podczas zapisywania punktów krzywej beziera przyjąłem dokładność 0.01, tak żeby można było w szybki sposób za pomocą X'a znaleźć wartość krzywej w tym punkcie.

Serializacja krzywych odbywa się za pomocą JSON'a. Punkty są zapisywane za pomocą double w przedziale 0 - 1 (zarówno X jak i Y) i podczas importu odpowiednio skalowane do wysokości / szerokości bitmapy z krzywymi.

Projekt został utworzony z użyciem .NET 6.0 (najnowsza wersja).