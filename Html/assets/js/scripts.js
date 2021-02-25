function fw_initPage(){
    // breadcrumb
    var separator =' > ';
    var bc = $('.fw-tree li.active').parentsUntil('.fw-tree').toArray().filter(a=>$(a).is('li')).map(a=>$('>a',a).text()).reverse().join(separator)+separator+$('.fw-tree li.active>a').text();
    $('.fw-breadcrumb').text(bc);

    // tree button
    $('.btnToggleTree').on('click',function(){
        $('.fw-treemenu').toggleClass('expanded');
    });
    $('a.tree-item.node-group').on('click',function(e){
        e.stopPropagation();
        $(this).parent().toggleClass('collapsed');
        return false; 
    })
}

function fw_toggleTree(){
    $('.fw-treemenu').toggleClass('expanded');
}

$(function(){
    fw_initPage();
});