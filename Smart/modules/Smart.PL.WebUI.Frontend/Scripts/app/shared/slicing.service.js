(function () {
    angular
    .module("smartModule")
    .factory("slicingService", slicingService);

    function slicingService($window) {
        var service = {
            sliceSlides: sliceSlides
        };
        return service;

        function sliceSlides(items) {
            var CELL_WIDTH = 250 + 5;	    	                        // ( .width + .marginLeft )				--  How to get it from CSS programmatically ?
            var ITEMS_PER_SLIDE = Math.min(
                4,                                                      // maximal quantity of cells
                Math.floor((window.innerWidth - 2 * 35) / CELL_WIDTH)   // 2 * 35 = 2 * .padding(".nia-part")	--  How to get it from CSS programmatically ?
            );

            var slides = [];
            for (var i = 0 ; i < items.length ; i += ITEMS_PER_SLIDE ) {
                slides.push(items.slice(i, i + ITEMS_PER_SLIDE));
            }
            return slides;
        };
    }

})(angular);