tinymce.init({
    selector: '#action_editor',
    width: 925,
    height: 325,
    resize: false
});
tinymce.init({
    selector: '#description_editor',
    width: 925,
    height: 325,
    resize: false
});
tinymce.init({
    selector: '#dev_notes_editor',
    width: 925,
    height: 325,
    resize: false
});
tinymce.init({
    selector: '#billing_notes_editor',
    width: 925,
    height: 325,
    resize: false
});

let table = new DataTable('#dash-table')