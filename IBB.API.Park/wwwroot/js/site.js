function init() {
    $.get("/map/get").then(resp => {
        console.log(resp);
        createMap(resp);

        $(".map-loader").remove();
    });
}
init();

function createMap(parkList) {
    ymaps.ready(function () {
        var myMap = new ymaps.Map('map', {
            center: [parkList[0].longitude, parkList[0].latitude],
            zoom: 5
        }, {
            searchControlProvider: 'yandex#search'
        });

        // Creating a content layout.
        MyIconContentLayout = ymaps.templateLayoutFactory.createClass(
            //'<div style="color: #000; font-weight: bold; background: #fff; box-shadow: 1px 2px 10px -2px rgba(0,0,0,0.5); border-radius: 50%; width: 20px; height: 20px; display: flex; align-items:center;justify-content:center">$[properties.iconContent]</div>'
        );

        for (let i = 0; i < parkList.length; i++) {
            const park = parkList[i];
            myPlacemark = new ymaps.Placemark([park.longitude, park.latitude], {
                hintContent: park.name,
                balloonContent: `Go to <a href="${park.locationUrl}" target="_blank">city map</a>`
                //iconContent: parkList.length
            }, {
                /**
                 * Options.
                 * You must specify this type of layout.
                 */
                iconLayout: 'default#imageWithContent',
                // Custom image for the placemark icon.
                iconImageHref: 'https://cdn0.iconfinder.com/data/icons/small-n-flat/24/678111-map-marker-32.png',
                // The size of the placemark.
                iconImageSize: [32, 32],
                /**
                 * The offset of the upper left corner of the icon relative
                 * to its "tail" (the anchor point).
                 */
                iconImageOffset: [-24, -24],

                //iconContentOffset: [15, 15],
                //iconContentLayout: MyIconContentLayout
            });

            myMap.geoObjects
                .add(myPlacemark);
        }





        //myPlacemarkWithContent = new ymaps.Placemark([40.957846, 28.812055], {
        //    hintContent: 'A custom placemark icon with contents',
        //    balloonContent: 'This one — for Christmas',
        //    iconContent: '12'
        //}, {
        //    /**
        //     * Options.
        //     * You must specify this type of layout.
        //     */
        //    iconLayout: 'default#imageWithContent',
        //    // Custom image for the placemark icon.
        //    //iconImageHref: 'https://cdn0.iconfinder.com/data/icons/small-n-flat/24/678111-map-marker-32.png',
        //    // The size of the placemark.
        //    iconImageSize: [32,32],
        //    /**
        //     * The offset of the upper left corner of the icon relative
        //     * to its "tail" (the anchor point).
        //     */
        //    iconImageOffset: [-24, -24],
        //    // Offset of the layer with content relative to the layer with the image.
        //    iconContentOffset: [15, 15],
        //    // Content layout.
        //    iconContentLayout: MyIconContentLayout
        //});

    });
}
