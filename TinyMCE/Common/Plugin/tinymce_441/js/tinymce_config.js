tinymce.init({
    selector: 'textarea',
    width: 800,
    height: 500,
    theme: 'modern',
    plugins: [
      'advlist autolink lists link image charmap print preview hr anchor pagebreak',
      'searchreplace wordcount visualblocks visualchars code fullscreen',
      'insertdatetime media nonbreaking save table contextmenu directionality',
      'emoticons template paste textcolor colorpicker textpattern imagetools code'
    ],
    toolbar: [
        'insertfile undo redo | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | code link custom_image media | forecolor backcolor emoticons'
    ],
    image_advtab: true,
    relative_urls: false,
    automatic_uploads: false,
    setup: function (editor) {
        editor.addButton('custom_image', {
            icon: 'image',
            onclick: function () {
                tinymce.activeEditor.windowManager.open({
                    url: '/BBS/OpenImages',
                    title: 'Select File',
                    width: 600,
                    height: 200,
                    buttons: [{
                        text: 'submit',
                        id: 'btn-submit',
                        onclick: function () {
                            alert('click submit btn');
                        }
                    },
                    {
                        text: 'Cancel',
                        id: 'btn-cancel',
                        onclick: 'close'
                    }]
                });
            }
        });
    }
});
//http://stackoverflow.com/questions/27587451/change-configuration-of-button-on-windowmanager-tinymce

