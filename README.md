# xamarin-paris-coffee
Bootstrap resources to support training on xamarin platform.  
[App Preview](snippets/app.screens.png)


## Training plan :  

* J1 : Discovering the platform, and workstation setup
* J2 : Implement App core features . View [more](snippets/service-tests.md)
* J3 : Implement iOs App
* J4 : Implement Android App
* J5 : Discovering Xamarin.Forms

## App technical design

![Technical design](snippets/technical.design.png)

## Datastructure

Make the following request to test the API :  

```sh
curl  http://opendata.paris.fr/api/records/1.0/search/?dataset=liste-des-cafes-a-un-euro
```
And you will get the following datastructure :  

```json
{
    "format": "json",
    "nhits": 1,
    "records": [
        {
            "datasetid": "liste-des-cafes-a-un-euro",
            "fields": {
                "adresse": "344Vrue Vaugirard",
                "arrondissement": 75015,
                "date": "2014-02-01",
                "geoloc": [
                    48.839471,
                    2.30286
                ],
                "nom_du_cafe": "Coffee Chope",
                "prix_comptoir": 1,
                "prix_salle": "-",
                "prix_terasse": "-"
            },
            "geometry": {
                "coordinates": [
                    2.30286,
                    48.839471
                ],
                "type": "Point"
            },
            "record_timestamp": "2016-02-14T23:00:04+00:00",
            "recordid": "4588e58f447fb4dd5df12eafbaf7d9314decd475"
        }
    ],
    "rows": 10,
    "timezone": "UTC"
}
```


# Adddional resources

* http://petrnohejl.github.io/Android-Cheatsheet-For-Graphic-Designers/

* https://www.makerscabin.com/ios/design/cheat-sheet?/ios/cheat-sheet

* http://opendata.paris.fr/explore/dataset/liste-des-cafes-a-un-euro/

* [Android vs iOS view lifecycle](https://twitter.com/talant_a/status/699333527389794307)

