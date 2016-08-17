tinymce.init({
    selector: '#mytextarea',
    width: 800,
    height: 500,
    toolbar: 'undo redo | styleselect bold italic | alignleft aligncenter alignright | bullist numlist | outdent indent | code image custom_image',
    plugins: 'code image',
    menubar: 'file edit insert view format tools',
    setup: function (editor) {
        editor.addButton('custom_image', {
            title: 'Custom Image',
            icon: 'image',
            onclick: function () {
                window.open('http://www.google.com','Attach Images','width=600,height=400')
            }
        })
    }
});