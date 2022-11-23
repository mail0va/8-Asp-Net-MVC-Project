﻿$(document).ready(() => {
    $(".searchBtn").click(() => {
        let searchInput = $(" .searchInput").val();
        let searchCategory = $(" searchCategory option: selected").val();

        if (searchInput.length >= 2) {
            fetch('/shop/search/' + searchCategory + '?search=' + searchInput)
                .then(response => {
                    return response.text();
                }).then(data => {
                    $("#searchList").html(data);
                })
        }
        //OLD PARTIAL
        //if (searchInput.length >= 2) {
        //    fetch('/shop/search/' + searchCategory + '?search=' + searchInput)
        //        .then(response => {
        //            return response.json();
        //        }).then(data => {
        //            //console.log(data)
        //            let liItems = '';
        //            for (var i = 0; i < data.length; i++) {
        //                let liItem = `
        //          <li>
        //            <img width="100" src="/assets/images/product/${data[i].image}" alt="Alternate text"/>
        //            <a> ${data[i].title}</a>
        //          </li>`
        //                liItems += liItem;
        //            }
        //            //console.log(liItems);
        //            $("#searchList").html(liItems);
        //        })
        //}
    })

    $(".searchInput").keyup(function () {
        let inputVal = $(this).val();
        if (inputVal.length<=0) {
            $(".searchList").html('');
        }
    })
})